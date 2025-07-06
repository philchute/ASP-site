using ICSharpCode.SharpZipLib.BZip2;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Globalization;

namespace ASP_site.Helpers
{
    public static class PacketUtils
    {
        public static byte ReadByte(BinaryReader reader)
        {
            return reader.ReadByte();
        }

        public static short ReadShort(BinaryReader reader)
        {
            return IPAddress.NetworkToHostOrder(reader.ReadInt16());
        }

        public static int ReadInt(BinaryReader reader)
        {
            return IPAddress.NetworkToHostOrder(reader.ReadInt32());
        }

        public static long ReadLong(BinaryReader reader)
        {
            return IPAddress.NetworkToHostOrder(reader.ReadInt64());
        }

        public static float ReadFloat(BinaryReader reader)
        {
            byte[] floatBytes = reader.ReadBytes(4);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(floatBytes);
            }
            return BitConverter.ToSingle(floatBytes, 0);
        }

        public static string ReadString(BinaryReader reader, Encoding? encoding = null)
        {
            encoding ??= Encoding.UTF8; // Default to UTF-8 if no encoding is provided
            var bytes = new List<byte>();
            byte b;
            // Ensure reading stops if end of stream is reached unexpectedly
            while (reader.BaseStream.Position < reader.BaseStream.Length && (b = reader.ReadByte()) != 0x00)
            {
                bytes.Add(b);
            }
            return encoding.GetString(bytes.ToArray()); // Assume GetString handles empty array correctly
        }

        public static IPEndPoint CreateIPEndPoint(string endPoint)
        {
            string[] ep = endPoint.Split(':');
            if (ep.Length != 2) throw new FormatException("Invalid endpoint format");

            if (!IPAddress.TryParse(ep[0], out IPAddress? ip))
            {
                throw new FormatException($"Invalid ip-adress: {ep[0]}");
            }
            // ip is guaranteed to be non-null here due to the check above

            if (!int.TryParse(ep[1], NumberStyles.None, NumberFormatInfo.CurrentInfo, out int port))
            {
                throw new FormatException($"Invalid port: {ep[1]}");
            }
            return new IPEndPoint(ip, port); // Use the non-null ip
        }

        public static byte[] DecompressBZip2(byte[] compressedData)
        {
            using var compressedStream = new MemoryStream(compressedData);
            using var outputStream = new MemoryStream();
            try
            {
                BZip2.Decompress(compressedStream, outputStream, true);
                return outputStream.ToArray();
            }
            catch (Exception ex)
            {
                // Handle or log the decompression error appropriately
                Console.WriteLine($"BZip2 decompression failed: {ex.Message}");
                throw; // Rethrow or handle as needed
            }
        }

        // Consider adding methods for writing packet data if needed for sending challenges or other requests
        public static void WriteByte(BinaryWriter writer, byte value)
        {
            writer.Write(value);
        }

        public static void WriteShort(BinaryWriter writer, short value)
        {
            writer.Write(IPAddress.HostToNetworkOrder(value));
        }

        public static void WriteInt(BinaryWriter writer, int value)
        {
            writer.Write(IPAddress.HostToNetworkOrder(value));
        }

        public static void WriteString(BinaryWriter writer, string value, Encoding? encoding = null)
        {
            encoding ??= Encoding.UTF8;
            byte[] bytes = encoding.GetBytes(value);
            writer.Write(bytes);
            writer.Write((byte)0x00); // Null terminator
        }
    }
} 