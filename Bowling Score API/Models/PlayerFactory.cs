using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class PlayerFactory
    {
        string[] players = { "Sarah", "Jordan", "Rich", "Kristen",
"Deanna", "George", "Julie", "Annalise",
"Whitney", "Mark" };
        private static int m_Counter = 0;

        private static Random _R = new Random();
        
        
        public Player RandomPlayer()
        {
            var Id = System.Threading.Interlocked.Increment(ref m_Counter);
            var index = _R.Next(0, players.Length);
            var DisplayName = players[index];


            return new Player(Id, DisplayName);

        }

    }
}
