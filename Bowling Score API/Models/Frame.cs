using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Asn1.Sec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class Frame
    {
        public int Id { get; set; }
        public int FirstRoll { get; set; }
        public int SecondRoll { get; set; }
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

        public bool IsTenthFrame()
        {
            if (Id % 10 == 0)
            {
                return true;
            } else
            {
                return false; 
            }
        }

        public Frame(int id, int firstRoll, int secondRoll)
        {
            Id = id;
            if (firstRoll >= 0  && firstRoll <=10)
            {
                FirstRoll = firstRoll;

            } else
            {
                Console.WriteLine("Please pick a number between 0-10");
            }
            if (secondRoll >= 0 && secondRoll <= 10-firstRoll)
            {
                SecondRoll = secondRoll;

            }
            else
            {
                Console.WriteLine($"Please pick a number between 0 & {10-firstRoll}");
            }

        }
    }
}
