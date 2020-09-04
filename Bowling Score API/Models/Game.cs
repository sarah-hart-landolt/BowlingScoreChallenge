using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class Game
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public void addPlayer(Player player)
        {

            Players.Add(player);
        }

        public List<Frame> Frames { get; set; } = new List<Frame>();

        public void PlayGame()
        {
            for (int i = 0; i < 10; i++)
            {
                var frame = new Frame();

                Frames.Add(frame);
            }

            if(Frames[9].FirstRoll == 10 || Frames[9].FirstRoll + Frames[9].SecondRoll == 10)
            {
                var extraFrame = new Frame();
                Frames.Add(extraFrame);
            }                

        }



    }
}
