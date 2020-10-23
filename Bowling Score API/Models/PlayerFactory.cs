using System;
using System.Collections.Generic;


namespace Bowling_Score_API.Models
{
    public class PlayerFactory
    {
        public List<string> players = new List<string>{ "Sarah", "Jordan", "Rich", "Kristen", "Matthew George", "Max",
                                                        "Deanna", "George", "Julie", "Annalise","Whitney", "Mark" };
        private static int m_Counter = 0;

        private static Random rnd = new Random();


        public Player RandomPlayer()
        {
            var Id = System.Threading.Interlocked.Increment(ref m_Counter);
            var index = rnd.Next(0, players.Count);
            var DisplayName = players[index];


            return new Player(Id, DisplayName);

        }

    }
}
