using System;
using System.Collections.Generic;


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
        // outer factories will be building up your games with randmoness (game factory-- in the game factory is the randomness ) 
        // method injection passing in a frame when you do it.
        
        /// <summary>
        /// add possibilty of 3rd roll in last frame here 
        /// </summary>
        public void BowlingCardScore()
        {

            var score = 0;

            for (var i = 0; i < 10
                ; i++)

                if (Frames[i].IsASpare()) // if it's a spare
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
                else if (Frames[i].IsAStrike()) // if it's a strike
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

            Console.WriteLine($"Good game {DisplayName}. Your score is {score}");


        }

    }

}

    

