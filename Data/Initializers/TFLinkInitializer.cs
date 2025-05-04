using ASP_site.Models;

namespace ASP_site.Data.Initializers
{
  public static class TFLinkInitializer
  {
    public static Link GetWikiLink(string mapID)
    {
      return new Link
      {
        Label = $"TF2 {mapID} Wiki page",
        Description = $"Official Team Fortress wiki TF2 {mapID} page",
        LinkType = LinkType.Wiki,
        MapID = mapID,
        GameID = "TF2",
        Url = $"https://wiki.teamfortress.com/wiki/{mapID}"
      };
    }
    
    public static Link GetWikiLinkClassic(string mapID)
    {
      return new Link
      {
        Label = $"TFC {mapID} Wiki page",
        Description = $"Official Team Fortress wiki TFC {mapID} page",
        LinkType = LinkType.Wiki,
        MapID = mapID,
        GameID = "TFC",
        Url = $"https://wiki.teamfortress.com/wiki/{mapID}_(Classic)"
      };
    }

    public static Link GetRepoLink(string mapID)
    {
      return new Link
      {
        Label = $"QWTF {mapID} Map Repo",
        Description = $"QWTF {mapID} map repository on GitHub",
        LinkType = LinkType.Download,
        MapID = mapID,
        GameID = "QWTF",
        Url = $"https://github.com/FortressOne/map-repo/tree/master/fortress/package/{mapID}"
      };
    }
    
    
    public static Link[] GetLinks()
    {
      return new Link[]
      {
        // QWTF
        new Link { GameID = "QWTF", Label = "Team Fortress Done Extreme", Description = "Team Fortress Done Extreme",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/23bfEouzFxY" },
        new Link { GameID = "QWTF", Label = "Team Fortress Done Extreme 2", Description = "Team Fortress Done Extreme 2",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/gPEkSWj6Jyc" },
        new Link { GameID = "QWTF", Label = "QWTF - The Redemption", Description = "QWTF - The Redemption",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/uepAtTQhyVs" },

        // AttackersGoRed
        new Link { GameID = "AttackersGoRed", Label = "Attackers Go Red", Description = "Me playing Medic on rock2", 
          LinkType = LinkType.Gameplay, MapID = "rock2", Url = "https://www.youtube.com/watch?v=MxRhBqu5vT4" },
          
        // CustomTF
        new Link { GameID = "CustomTF", Label = "QuakeWorld Prozac CustomTF website", Description = "QuakeWorld Prozac CustomTF website",
          LinkType = LinkType.Official, Url = "http://quake.midioz.com/" },

        // MegaTF
        new Link { GameID = "MegaTF", Label = "Mega Fortress Wiki", Description = "Mega Fortress Wiki",
          LinkType = LinkType.Wiki, Url = "https://wiki.megateamfortress.com/Main_Page" },

        // FortressOne
        new Link { GameID = "FortressOne", Label = "FortressOne", Description = "FortressOne Official Site",
          LinkType = LinkType.Official, Url = "https://www.fortressone.org/" },
        new Link { GameID = "FortressOne", Label = "FortressOne Official Discord", Description = "FortressOne Official Discord",
          LinkType = LinkType.OfficialDiscord, Url = "https://discord.fortressone.org" },
        new Link { GameID = "FortressOne", Label = "FortressOne Latest Release", Description = "FortressOne Latest Release",
          LinkType = LinkType.Download, Url = "https://github.com/FortressOne/windows-installer/releases/latest" },
        new Link { GameID = "FortressOne", Label = "schtop snoozer stall", Description = "Me playing on ff-schtop", 
          LinkType = LinkType.Gameplay, MapID = "schtop", Url = "https://www.youtube.com/watch?v=gUqfgc7jS98" },
        new Link { GameID = "FortressOne", Label = "prelude in phantom", Description = "Me playing on ff-phantom", 
          LinkType = LinkType.Gameplay, MapID = "phantom", Url = "https://www.youtube.com/watch?v=WwoQJK-gY6Q" },
        new Link { GameID = "FortressOne", Label = "Spy Attacks on Swoop", Description = "Me playing spy on swoop", 
          LinkType = LinkType.Gameplay, MapID = "swoop", Url = "https://www.youtube.com/watch?v=SDTcWKMXvGg" },
        new Link { GameID = "FortressOne", Label = "Weird pyro plays", Description = "Me playing pyro on openfire", 
          LinkType = LinkType.Gameplay, MapID = "openfire", Url = "https://www.youtube.com/watch?v=2smzY17Hp7E" },
        new Link { GameID = "FortressOne", Label = "moving the flag out of destroy", Description = "Me playing on ff-destroy", 
          LinkType = LinkType.Gameplay, MapID = "destroy", Url = "https://www.youtube.com/watch?v=ajTd3L8n6_w" },
        new Link { GameID = "FortressOne", Label = "ff-2fort 4v4 pickup", Description = "Me playing 4v4 pickup on ff-2fort", 
          LinkType = LinkType.Gameplay, MapID = "2fort", Url = "https://youtu.be/1cnDFJhg55A" },

        // Q3F
        new Link { GameID = "Q3F", Label = "Quake 3 Fortress - The Dark Side", Description = "Quake 3 Fortress - The Dark Side",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/r1m50MI1WJk" },

        // ETF
        new Link { GameID = "ETF", Label = "Enemy Territory Fortress Promo - ETF", Description = "Enemy Territory Fortress Promo - ETF",
          LinkType = LinkType.Trailer, Url = "https://www.youtube.com/watch?v=autxXIr7KOg" },
        new Link { GameID = "ETF", Label = "Moose & More - ETF Extreme", Description = "Moose & More - ETF Extreme",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/ZKlk6REUL70" },

        // TFC
        new Link { GameID = "TFC", Label = "Nuki's TFC Learning Center", Description = "Nuki's TFC Learning Center",
          LinkType = LinkType.Guide, Url = "https://sites.google.com/view/nlc-tfc/home" },
        new Link { GameID = "TFC", Label = "20th Anniversary Retrospective", Description = "20th Anniversary Retrospective",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/q9nJLfjx7sA" },
        new Link { GameID = "TFC", Label = "Defrag and vriens TFC Skills movie", Description = "Defrag and vriens TFC Skills movie",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/LvTd9JkElNU" },
        new Link { GameID = "TFC", Label = "Skillout", Description = "Skillout",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/kRrjh8yp5yE" },
        new Link { GameID = "TFC", Label = "Team Spirit", Description = "Team Spirit",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/fbXsFZShsSE" },
        new Link { GameID = "TFC", Label = "Plain", Description = "Plain",
          LinkType = LinkType.Highlights, Url = "https://youtu.be/V3Qu_47uUxI" },
        new Link { GameID = "TFC", Label = "TFC Maps", Description = "TFC Maps",
          LinkType = LinkType.Download, Url = "https://tfcmaps.net/" },

        // TF2
        new Link { GameID = "TF2", Label = "Errant Signal: Social Spaces & Payload Races", Description = "Compares the social experience of TF2 and Overwatch",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/-hj1haLcdI0" },
        new Link { GameID = "TF2", Label = "What happens when overwatch players play TF2", Description = "What happens when overwatch players play TF2",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/rGHazA5a0pM" },
        new Link { GameID = "TF2", Label = "the best competitive game that nobody plays", Description = "the best competitive game that nobody plays",
          LinkType = LinkType.Documentary, Url = "https://youtu.be/iHtmqtsRi3I" },
        new Link { GameID = "TF2", Label = "The soul of TF2 in one clip", Description = "The soul of TF2 in one clip",
          LinkType = LinkType.Gameplay, Url = "https://youtu.be/2hu1bUHL1mc" },

        // FF
        new Link { GameID = "FF", Label = "Fortress Forever Official Site", Description = "Fortress Forever Official Site",
          LinkType = LinkType.Official, Url = "https://www.fortress-forever.com" },
        new Link { GameID = "FF", Label = "Fortress Forever Official Discord", Description = "Fortress Forever Official Discord",
          LinkType = LinkType.OfficialDiscord, Url = "https://discord.gg/jCphsAE" },
        new Link { GameID = "FF", Label = "Fortress Forever Official Wiki", Description = "Fortress Forever Official Wiki",
          LinkType = LinkType.Guide, Url = "http://www.fortress-forever.com/wiki/index.php?title=Main_Page" },
        new Link { GameID = "FF", Label = "Fortress Forever Fan Page", Description = "Fortress Forever Fan Page",
          LinkType = LinkType.Guide, Url = "https://sites.google.com/view/fortress-forever-fan-page/guide" },
        new Link { GameID = "FF", Label = "TF2 player's guide to Fortress Forever", Description = "4v4 rules, grenades, how to conc jump",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=Cp-cETaiqDY" },
        new Link { GameID = "FF", Label = "4v4 Competitive Team Fortress Guide", Description = "FortressOne, Team Fortress Classic, Fortress Forever guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=AsL-xzc580o" },
        new Link { GameID = "FF", Label = "Fortress Forever config file guide", Description = "Configuration file setup guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=gSaps9aGBRQ" },
        new Link { GameID = "FF", Label = "Rampsliding blog post", Description = "Rampsliding blog post", 
          LinkType = LinkType.Guide, Url = "https://www.ryanliptak.com/blog/rampsliding-quake-engine-quirk/" },
        new Link { GameID = "FF", Label = "FF crosshair guide", Description = "FF crosshair guide",
          LinkType = LinkType.Guide, Url = "https://steamcommunity.com/sharedfiles/filedetails/?id=2229416739" },
        new Link { GameID = "FF", Label = "Fortress Forever Demoman guide", Description = "Demoman class guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=0VP8IxjgDC8" },
        new Link { GameID = "FF", Label = "Fortress Forever Engineer guide", Description = "Engineer class guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=aCeXI5WEp3c" },
        new Link { GameID = "FF", Label = "Fortress Forever Spy guide", Description = "Spy class guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=gPTUd-42de8" },
        new Link { GameID = "FF", Label = "Fortress Forever bases map guide", Description = "ff_bases map guide",
          LinkType = LinkType.Guide, MapID = "bases", Url = "https://www.youtube.com/watch?v=X16fuUnSSLQ" },
        new Link { GameID = "FF", Label = "Fortress Forever destroy map guide", Description = "ff_destroy map guide",
          LinkType = LinkType.Guide, MapID = "destroy", Url = "https://www.youtube.com/watch?v=tpQNCKtDeTc" },
        new Link { GameID = "FF", Label = "Fortress Forever medieval map guide", Description = "Medieval map guide",
          LinkType = LinkType.Guide, MapID = "medieval", Url = "https://www.youtube.com/watch?v=TcaTtIg8fbU" },
        new Link { GameID = "FF", Label = "Fortress Forever phantom map guide", Description = "ff_phantom_r map guide",
          LinkType = LinkType.Guide, MapID = "phantom", Url = "https://www.youtube.com/watch?v=Tv4rZmzaKbA" },
        new Link { GameID = "FF", Label = "Fortress Forever shutdown map guide", Description = "ff_shutdown2 map guide",
          LinkType = LinkType.Guide, MapID = "shutdown2", Url = "https://www.youtube.com/watch?v=Z2GIVYdFk9k" },
        new Link { GameID = "FF", Label = "Fortress Forever swoop map guide", Description = "Swoop map guide",
          LinkType = LinkType.Guide, MapID = "swoop", Url = "https://www.youtube.com/watch?v=zOiExfXYM2U" },
        new Link { GameID = "FF", Label = "Trimp Jumping in Fortress Forever", Description = "Trimp jumping on trimp_trainingz_b2",
          LinkType = LinkType.Guide, MapID = "trimp_trainingz", Url = "https://www.youtube.com/watch?v=GUSoBXCtjXc" },
        new Link { GameID = "FF", Label = "Fortress Forever SDK2013 port beta", Description = "Public beta update news and install guide",
          LinkType = LinkType.Guide, Url = "https://www.youtube.com/watch?v=mbpyssjZLas" },
        new Link { GameID = "FF", Label = "Fortress Forever 4v4 pickup game", Description = "Full match with commentary on SDK2013 port",
          LinkType = LinkType.Gameplay, Url = "https://www.youtube.com/watch?v=ikYhLU6D2Rk" },
        new Link { GameID = "FF", Label = "swoop engineer bingo", Description = "My playing engineer on swoop, many kill types in one game", 
          LinkType = LinkType.Gameplay, MapID = "swoop", Url = "https://www.youtube.com/watch?v=PX1wEY3MMxk" },
        new Link { GameID = "FF", Label = "Scout phantom", Description = "Me playing scout on ff_phantom", 
          LinkType = LinkType.Gameplay, MapID = "phantom", Url = "https://www.youtube.com/watch?v=s6AmiHUjpXw" },
        new Link { GameID = "FF", Label = "the soldier game", Description = "The four soldier defense on ff_tidal_b3", 
          LinkType = LinkType.Gameplay, MapID = "tidal", Url = "https://www.youtube.com/watch?v=7RXkH-eiwaM" },
        new Link { GameID = "FF", Label = "demoman full half", Description = "Me playing demoman on ff_nyx", 
          LinkType = LinkType.Gameplay, MapID = "nyx", Url = "https://www.youtube.com/watch?v=-tB8Y_Cs758" },
        new Link { GameID = "FF", Label = "destroy demoman chaos", Description = "Me playing demoman on ff_destroy", 
          LinkType = LinkType.Gameplay, MapID = "destroy", Url = "https://www.youtube.com/watch?v=f8O7dPmuqAI" },
        new Link { GameID = "FF", Label = "Pitfalls of pitfall - We don't go to pitfall", Description = "Me playing on ff_pitfall", 
          LinkType = LinkType.Gameplay, MapID = "pitfall", Url = "https://youtu.be/1NgpsZpVdLI" },
        new Link { GameID = "FF", Label = "FF schtop water game", Description = "Engineer/scout full game on ff_schtop", 
          LinkType = LinkType.Gameplay, MapID = "schtop", Url = "https://youtu.be/X0Ew4xIhMRg" },
        new Link { GameID = "FF", Label = "Engineer adventures on mortality", Description = "Me playing engineer on ff_mortality_gz_b1", 
          LinkType = LinkType.Gameplay, MapID = "mortality", Url = "https://youtu.be/jsqyuPHQfkY" },
        new Link { GameID = "FF", Label = "Interesting start on catharsis", Description = "Me playing demoman on ff_catharsis_b4", 
          LinkType = LinkType.Gameplay, MapID = "catharsis", Url = "https://www.youtube.com/watch?v=NdgzhbyzspU" }
      };
    }
  }
} 