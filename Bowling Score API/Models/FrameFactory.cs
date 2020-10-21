using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class FrameFactory
    {
        private static readonly Random rnd = new Random();


        public static Frame RandomFrame() {
            var FirstRoll = 0;
            var SecondRoll = 0;

            FirstRoll = rnd.Next(0, 11);
            if (FirstRoll == 10)
            {
                SecondRoll = 0;
            } else
            {
                SecondRoll = rnd.Next(0, 11 - FirstRoll);

            }
            return new Frame(FirstRoll, SecondRoll);

        }


    }
}
