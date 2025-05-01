using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
  public static class CSLinkInitializer
  {
    public static Link GetWikiLink(string mapID)
    {
      return new Link
      {
        Label = $"{mapID} fandom page",
        Description = $"{mapID} on fandom wiki",
        LinkType = LinkType.Wiki,
        MapID = mapID,
        GameID = "",
        Url = $"https://counterstrike.fandom.com/wiki/{mapID}"
      };
    }
    public static Link[] GetLinks()
    {
      return new Link[]
      {
        // CS16
        new Link { GameID = "CS16", Label = "Where CS Happens (Where Amazing Happens) by EJA", Description = "Classic CS 1.6 edit spoofing an old NBA ad",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/H4r3EJXo25Q" },
        new Link { GameID = "CS16", Label = "eoLithic - The Movie", Description = "Classic CS 1.6 edit of old school team eoLithic",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/DQROf32t4yQ" },
        new Link { GameID = "CS16", Label = "eoLithic - Oslo by Storm", Description = "Classic CS 1.6 edit of old school team eoLithic",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/REjjTOSzeE4" },
        new Link { GameID = "CS16", Label = "The Story of Door Stuck", Description = "Door stuck documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/cXFBHtaQd40" },
        new Link { GameID = "CS16", Label = "play-cs", Description = "Me playing gun game on fy_pool_day on play-cs.com", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=aM1ocjaRXaE" },

        // CSCZ
        new Link { GameID = "CSCZ", Label = "VNN: The History of Counter-Strike: Condition Zero", Description = "CS:CZ documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/E7dFt9-aGJQ" },
        new Link { GameID = "CSCZ", Label = "CS: CZ func_vehicle maps", Description = "Me playing some nipper func_vehicle maps with GSS", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=EOazC0R_nxk" },

        // CSGO
        new Link { GameID = "CSGO", Label = "The Story of CS:GO: The Game That Never Dies", Description = "CS:GO documentary",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/H8Nv--NOU2k" },
        new Link { GameID = "CSGO", Label = "Legendary Astalis' dev1ce - CSGO frag movie", Description = "One of my favorite CS:GO frag movies",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/J_lsx_qc70o" },
        new Link { GameID = "CSGO", Label = "6 year old kid wins CS:GO round", Description = "Classic Highlight: 6 year old kid wins CS:GO round",
          LinkType = LinkType.Highlights, MapID = "dust2", Url = "https://youtu.be/3-XekLszoQw" },
        new Link { GameID = "CSGO", Label = "CS:GO - Where Amazing Happens", Description = "Sequel to the classic CS 1.6 edit",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/dXd8JVRn7rY" },
        new Link { GameID = "CSGO", Label = "Let's do this Anubis", Description = "Me playing competitive gameplay on de_anubis", 
          LinkType = LinkType.Gameplay, MapID = "anubis", Url = "https://youtu.be/rLHM7OWsl0s" },
        new Link { GameID = "CSGO", Label = "CS:GO 2v2 Shortdust", Description = "Me playing 2v2 with Tweety on the old shortdust map", 
          LinkType = LinkType.Gameplay, MapID = "dust", Url = "https://youtu.be/E2ZYkwKia5w" },
        new Link { GameID = "CSGO", Label = "New Knife", Description = "Me playing 2v2 with Batman on nuke and the old boat house map", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtu.be/FAYz3AZ9dbM" },
        new Link { GameID = "CSGO", Label = "Dangerzone Hacker", Description = "Me playing Dangerzone vs a hacker", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/9YiGzlBM_WI" },
        new Link { GameID = "CSGO", Label = "Dangerzone Win", Description = "My first Dangerzone win", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rpvvpJED0DI" },
        new Link { GameID = "CSGO", Label = "Don't Forget to Plant", Description = "Me playing de_mirage 5v5", 
          LinkType = LinkType.Gameplay, MapID = "mirage", Url = "https://youtu.be/sqTsGzuoa8g" },
        new Link { GameID = "CSGO", Label = "Danger Zone Coaching", Description = "DZ gameplay on blacksite", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Uem9eQa3s7o" },

        // CS2
        new Link { GameID = "CS2", Label = "learning to fly on surf_pantheon", Description = "Surf gameplay on surf_pantheon", 
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/XEIIc1gFfpw" },
        new Link { GameID = "CS2", Label = "Counterstrike in 2024", Description = "Gameplay on de_overpass", 
          LinkType = LinkType.Gameplay, MapID = "overpass", Url = "https://www.youtube.com/watch?v=l7YBgaO3Jcw" },
        new Link { GameID = "CS2", Label = "CS2 combat surf", Description = "Combat surf gameplay", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=MewoHsaWHJo" },
        new Link { GameID = "CS2", Label = "CS2 zombie escape", Description = "Zombie escape gameplay on colors", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=RstiQUX9trw" },
        new Link { GameID = "CS2", Label = "CS2 nuke gameplay", Description = "Gameplay on de_nuke", 
          LinkType = LinkType.Gameplay, MapID = "nuke", Url = "https://www.youtube.com/watch?v=Odd3PLg8g2U" },
        new Link { GameID = "CS2", Label = "Arms Race insane game", Description = "Arms Race gameplay on ar_shoots", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Rp1jWGpNNJU" },
        new Link { GameID = "CS2", Label = "CS2 Scancodes", Description = "CS2 Keybind Scancodes guide", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=6E1FOMlyN-w" },
        new Link { GameID = "CS2", Label = "new map mills", Description = "CT gameplay on de_mills", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=Hlo6Ehs6Bbk" },
        new Link { GameID = "CS2", Label = "new map thera", Description = "T gameplay on de_thera", 
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=SUi8FzGwacc" },
        new Link { GameID = "CS2", Label = "Counter-strike guide", Description = "", 
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=3rMQ3YxADaY" },

        // Map Links
        // Competitive Maps
        // de_ancient
        new Link { MapID = "ancient", Label = "de_ancient CT guide", Description = "Birds's ancient CT side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=l9VUaYGzkvY" },
        // de_anubis
        new Link { MapID = "anubis", Label = "de_anubis CT guide", Description = "Flom's anubis CT side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=4hHn3X_fN6k" },
        // de_dust2
        // de_inferno
        new Link { MapID = "inferno", Label = "de_inferno CT guide", Description = "Flom's inferno CT side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=p-7jOK8eTT8" },
        new Link { MapID = "inferno", Label = "de_inferno CT guide", Description = "Bird's inferno CT side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=DYUyvAYq0tg" },
        // de_mirage
        // de_nuke
        new Link { MapID = "nuke", Label = "de_nuke CT guide", Description = "Flom's nuke CT side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=vMRGwVx_v-Q" },
        new Link { MapID = "nuke", Label = "de_nuke CT guide", Description = "Bird's nuke CT side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=SR7CXB4mBA4" },
        new Link { MapID = "nuke", Label = "de_nuke T guide", Description = "Bird's nuke T side guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=YcDNhoX3yos" },
        // de_train

        // Other maps
        // de_overpass
        // de_vertigo
      };
    }
  }
} 