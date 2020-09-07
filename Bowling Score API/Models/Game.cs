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
                for (var i = 0; i < 10
                    ; i++)

                    if (Frames[i].FirstRoll != 10 && Frames[i].total == 10) // if it's a spare
                    {
                        if (i != 9) // and it's  not the 10th frame 
                        {
                            score += Frames[i].total + Frames[i + 1].FirstRoll;

                        }
                        else // if it's the last frame 
                        {
                            score += Frames[i].total + Frames[i].ThirdRoll;
                            Console.WriteLine("I got an extra roll bc of a 10th frame spare");


                        }
                    }
                    else if (Frames[i].FirstRoll == 10) // if it's a strike
                    {
                        if (i != 9) // and it's not the 10th frame
                        {
                            score += Frames[i].FirstRoll + Frames[i + 1].total; // score equals 10 plus the next frame's total
                        }
                        else  // if it's the 10th frame 
                        {
                            score += Frames[i].total + Frames[i].ThirdRoll; // if there's a strike in the 10th frame, 2 extra rolls are added and total score are the three rolls
                            Console.WriteLine("I had an extra 2 rolls bc of a 10th frame strike");

                        }
                    }
                    else
                    {
                        score += Frames[i].total; // otherwise the score is the score + the sum of the current frame
                    }


                Console.WriteLine($"Good game {player.DisplayName}. Your score is {score}");

            }

        }


    }
}








