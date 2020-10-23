using System;
using System.Collections.Generic;


namespace Bowling_Score_API.Models
{
    public class Game
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

        // method injection
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


        // game factory -- new up player, frames and a game 
 

        public void GameScore()
        {
            foreach (var player in Players)
            {
                player.BowlingCardScore();

            }

        }

    }
}








