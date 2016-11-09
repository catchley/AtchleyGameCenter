using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AtchleyGameCenter.Models;

namespace AtchleyGameCenter.DAL
{
    public class GameCenterInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameCenterContext>
    {
        protected override void Seed(GameCenterContext context)
        {
            var players = new List<Player>
            {
            new Player{FirstName="Carson",LastName="Alexander",Birthday=DateTime.Parse("2000-09-01")},
            new Player{FirstName="Miller",LastName="Robert",Birthday=DateTime.Parse("1985-05-08")},
            new Player{FirstName="Johnson",LastName="Richard",Birthday=DateTime.Parse("1976-12-21")} 
            };

            players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();
            var games = new List<Game>
            {
            new Game{GameID=1,Title="Chess",Difficulty=3,},
            new Game{GameID=2,Title="Darts",Difficulty=1,},
            new Game{GameID=3,Title="Pong",Difficulty=2,},
            new Game{GameID=4,Title="Pool",Difficulty=2,}
            };
            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();
            var signups = new List<Signup>
            {
            new Signup{PlayerID=1,GameID=1,Rating=Rating.A},
            new Signup{PlayerID=1,GameID=2,Rating=Rating.B},
            new Signup{PlayerID=2,GameID=1,Rating=Rating.C},
            new Signup{PlayerID=2,GameID=3,Rating=Rating.D},
            new Signup{PlayerID=3,GameID=4,Rating=Rating.F}
            };
            signups.ForEach(s => context.Signups.Add(s));
            context.SaveChanges();
        }
    }
}