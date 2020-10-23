using System;


namespace Bowling_Score_API.Models
{
    public class FrameFactory
    {
        private static readonly Random rnd = new Random();
        private static int m_Counter = 0;

        public static Frame RandomFrame()
        {
            var FirstRoll = 0;
            var SecondRoll = 0;
            var Id = System.Threading.Interlocked.Increment(ref m_Counter);

            FirstRoll = rnd.Next(0, 11);

            if (FirstRoll == 10)
            {
                if(Id % 11 != 0)
                {
                    SecondRoll = 0;

                } else
                {
                    SecondRoll = rnd.Next(0, 11);
                }
            }
            else
            {
                SecondRoll = rnd.Next(0, 11-FirstRoll);
            }


            return new Frame(Id, FirstRoll, SecondRoll);
        }

    }


}

