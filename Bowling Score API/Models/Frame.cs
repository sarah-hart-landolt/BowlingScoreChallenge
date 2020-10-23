using Microsoft.Extensions.Logging;
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
            FirstRoll = firstRoll;
            SecondRoll = secondRoll;

        }
    }
}
