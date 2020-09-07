using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class Game
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public void addPlayer(Player player)
        {
            if (Players.Count < 5)
            {
                Players.Add(player);
                Console.WriteLine($"Welcome {player.DisplayName}. Let's Bowl!");

            }
            else
            {
                Console.WriteLine($"Sorry , {player.DisplayName} only 5 players can participate. Wait 'til the next game.");
            }
        }

        public void GameScore()
        {
            foreach (var player in Players)
            {
                player.PlayGame();
                player.BowlingCardScore();

            }

        }

    }
}








