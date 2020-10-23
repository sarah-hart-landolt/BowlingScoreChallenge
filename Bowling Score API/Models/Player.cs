using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Bowling_Score_API.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        private List<Frame> Frames { get; set; } = new List<Frame>();

        public void PlayerRoll(Frame frame)
        {
            
           Frames.Add(frame);

        }

        public Player(int id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
            

        }

        // fix the bugs 
        public void BowlingCardScore()
        {

            var score = 0;

            for (var i = 0; i < 10
                ; i++)

                if (Frames[i].IsASpare()) // if it's a spare
                {

                    score += Frames[i].total + Frames[i + 1].FirstRoll;

                    if (Frames[i].IsTenthFrame())
                    {

                        Console.WriteLine("I got an extra roll bc of a 10th frame spare");

                    } 
                }
                else if (Frames[i].IsAStrike()) // if it's a strike
                {
                    score += Frames[i].FirstRoll + Frames[i + 1].total; // score equals 10 plus the next frame's total
                    if (Frames[i].IsTenthFrame())
                    {
                        Console.WriteLine("I had an extra frame bc of a 10th frame strike");

                    }

                }
                else
                {
                    score += Frames[i].total; // otherwise the score is the score + the sum of the current frame
                }

            Console.WriteLine($"Good game {DisplayName}. Your score is {score}");


        }

    }

}



