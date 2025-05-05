using System.Net;

namespace ASP_site.GameServerListCommon.Model.A2S;

public class MasterInfo
{
  public IPAddress Address { get; set; }

  public ushort Port { get; set; }

  public MasterInfo(IPAddress address, ushort port)
  {
    Address = address;
    Port = port;
  }
}

public class MasterServer
{
  public MasterInfo[] Servers { get; set; } = [];

  public int Count => Servers?.Length ?? 0;
} 