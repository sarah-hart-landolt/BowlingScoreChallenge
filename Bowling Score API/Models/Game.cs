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


        public void PlayGame()
        {

            foreach (var player in Players)
            {

                for (int i = 0; i < 10; i++)
                {
                    var frame = new Frame();

                    player.Frames.Add(frame);
                }
            }

        }

        public void Score()
        {

            foreach (var player in Players)
            {
                var Frames = player.Frames;
               
                var score = 0;
                for (var i = 0; i < 10; i++)

                    if (i != 9 && Frames[i].total == 10)
                    {
                        score += Frames[i].total + Frames[i + 1].total;
                    }
                    else if (i != 9 && Frames[i].FirstRoll == 10)
                    {
                        score += Frames[i].FirstRoll + Frames[i + 1].total + Frames[i + 2].total;
                    }
                    else
                    {
                        score += Frames[i].total;
                    }
                if (Frames.Count == 11)
                {
                    if (Frames[9].FirstRoll == 10)
                    {
                        score += Frames[10].total;
                        Console.WriteLine("I had an extra frame bc of strike");

                    }
                    else if (Frames[9].total == 10)
                    {
                        score += Frames[10].FirstRoll;
                        Console.WriteLine("I had an extra frame bc of spare");


                    }
                }

                Console.WriteLine(score);

                Console.WriteLine($"Good job {player.DisplayName}");

            }

        }



    }
}


        

                    


   
