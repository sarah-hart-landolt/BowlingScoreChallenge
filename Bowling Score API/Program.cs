using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bowling_Score_API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Bowling_Score_API
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var game = new Game();
            game.addPlayer(new Player() { Id = 1, DisplayName = "Sarah" });
            game.addPlayer(new Player() { Id = 2, DisplayName = "Kristen" });
            game.addPlayer(new Player() { Id = 3, DisplayName = "Parker" });
            game.addPlayer(new Player() { Id = 4, DisplayName = "Jon" });
            game.addPlayer(new Player() { Id = 5, DisplayName = "Derek" });
            game.addPlayer(new Player() { Id = 6, DisplayName = "Crystal" });

            //game.PlayGame();
            foreach (var player in game.Players) {
                player.PlayGame();
                player.Score();

            }


        }

    }
}
