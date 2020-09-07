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

        private static readonly Random rnd = new Random();

        //private int? _first;
        //private int? _second;
        private static int m_Counter = 0;

        public int Id { get; set; }
        public int FirstRoll { get; set; }
        //{
        //    get
        //    {
        //        if (_first == null)
        //        {
        //            _first = rnd.Next(0, 11);
        //        };
        //        return _first.Value;
        //    }
        //}


        public  int SecondRoll { get; set; }

        public int ThirdRoll { get; set; }

        public int total
        {
            get
            {
                return FirstRoll + SecondRoll;
            }
        }

        public Frame()
        {
            Id = System.Threading.Interlocked.Increment(ref m_Counter);

            FirstRoll = rnd.Next(0, 11); // First Roll is Random number between 0 and 11
            if (Id % 10 != 0 ) // if the Frame Id is not a multiple of 10 (last frame in game)
            {
                if (FirstRoll == 10) // and if that first roll is a strike
                {
                    SecondRoll = 0; // make second roll a zero, since it can't be nullable

                }
                else // otherwise make second roll random range be based on how many pins were knocked down in first roll
                {
                    SecondRoll = rnd.Next(0, 11 - FirstRoll);

                }
            } else // if Id == mulitple of 10 (meaning last frame)
            {
                if (FirstRoll == 10) // if first roll in last frame is a strike 
                {
                    SecondRoll = rnd.Next(0, 11); // player gets two more rolls; make the second roll a random number
                        if(SecondRoll == 10) // if that extra roll is also a stike 
                    {
                        ThirdRoll = rnd.Next(0, 11); // player gets a third roll with range between 0 - 11

                    } else
                    {
                        ThirdRoll = rnd.Next(0, 11 - SecondRoll); // otherwise that third roll is based on how many pins are knocked down in Second Roll
                    }
                }
                else // if Id == 10 & the first roll isn't a strike 
                {
                    SecondRoll = rnd.Next(0, 11 - FirstRoll); // Second Roll is random 
                    if (FirstRoll + SecondRoll == 10) // if firstroll isn't a strike and the 10th frame total is a Spare
                    {
                        ThirdRoll = rnd.Next(0, 11); // player gets a third roll 
                    }
                      
                }
            }
            
           




        }
    }
}
