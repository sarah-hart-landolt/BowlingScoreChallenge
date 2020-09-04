using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class Frame
    {

        private static readonly Random rnd = new Random();

        private int? _first;
        private int? _second;

        public int FirstRoll
        {
            get
            {
                if (_first == null)
                {
                    _first = rnd.Next(0, 10);
                };
                return _first.Value;
            }
        }

    
    public int SecondRoll
        {
            get
            {
                if (FirstRoll == 10 && _second == null)
                {
                    _second = 0;
                }
                else if (FirstRoll < 10 && _second == null)
                {
                    _second = rnd.Next(0, 11 - FirstRoll);
                };
                return _second.Value;
            }
        }


    public int total {
            get
            {
               return FirstRoll +  SecondRoll;
            }
        }
    }
}
