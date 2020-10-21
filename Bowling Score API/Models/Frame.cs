using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class Frame
    {
        public int Id { get; set; }

        private static int m_Counter = 0;
        private static readonly Random rnd = new Random();

        public int FirstRoll { get; set; }

        public int SecondRoll { get; set; }

        public int ThirdRoll { get; set; }

        public int total
        {
            get
            {
                return FirstRoll + SecondRoll;
            }
        }


        public bool IsAStrike()
        {
            if (FirstRoll == 10)
            {
                return true;
            }
            else
            {
                return false; 
            }

        }

        public bool IsASpare()
        {
            if (FirstRoll != 10 && total == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool HasAThirdRoll()
        {
            if (IsLastFrame() && IsASpare() || IsAStrike())
                return true;
            else
            {
                return false;
            }
        }

        public bool IsLastFrame()
        {
            if (Id % 10 == 0)
            {
                return true;
            } else
            {
                return false; 
            }
        }

        public Frame(int firstRoll, int secondRoll)
        {
            Id = System.Threading.Interlocked.Increment(ref m_Counter);

            FirstRoll = firstRoll;
            if (!IsLastFrame()) // if the Frame Id is not a multiple of 10 (last frame in game)
            {
                if (IsAStrike()) // and if that first roll is a strike
                {
                    SecondRoll = 0; // make second roll a zero, since it can't be nullable

                } else
                {
                    SecondRoll = secondRoll;
                }
            }
            else // if Id == mulitple of 10 (meaning last frame)
            {
                if (IsAStrike()) // if first roll in last frame is a strike 
                    {
                    SecondRoll = secondRoll;
                    ThirdRoll = thirdRoll;
                }
                else // if Id == 10 & the first roll isn't a strike 
                {
                    SecondRoll = secondRoll; // Second Roll is random 
                    if (IsASpare()) // if firstroll isn't a strike and the 10th frame total is a Spare
                    {
                        ThirdRoll = rnd.Next(0, 11); // player gets a third roll 
                    }

                }
            }

        }
    }
}
