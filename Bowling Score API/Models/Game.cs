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
            {
                foreach (var player in Players)
                {
                    List<Frame> Frames = new List<Frame>();

                    for (int i = 0; i < 10; i++)
                    {
                        var frame = new Frame();

                        Frames.Add(frame);
                    }

                    if (Frames[9].FirstRoll == 10 || Frames[9].FirstRoll + Frames[9].SecondRoll == 10)
                    {
                        var extraFrame = new Frame();
                        Frames.Add(extraFrame);
                    }
                    var score = 0;
                    for (var i = 0; i < Frames.Count; i++)
                        if (Frames[i].total == 10)
                        {
                            score += Frames[i].total + Frames[i + 1].total;
                        }
                        else if (Frames[i].FirstRoll == 10)
                        {
                            score += Frames[i].FirstRoll + Frames[i + 1].total + Frames[i + 2].total;
                        }
                        else
                        {
                            score += Frames[i].total;
                        }
                    Console.WriteLine(score);
                    Console.WriteLine($"Good job {player.DisplayName}");

                }

            }



        }


    }
}
