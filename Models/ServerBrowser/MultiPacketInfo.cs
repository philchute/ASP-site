namespace ASP_site.Models
{
    public class MultiPacketInfo
    {
        public int ID { get; set; }
        public bool Compressed { get; set; }
        public int Total { get; set; }
        public int Number { get; set; }
        public short Size { get; set; }

        public List<byte> Payload { get; set; } = [];

        public bool Done => Total > 0 && Total == Payload.Count;
    }
} 