using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Score_API.Models
{
    public class GameFactory
    {
        public static Game BuildGameFactory()
        { 
            var game =  new Game();
            var play
            game.addPlayer(new Player());

            ///player.isLastRollStrike, if so add frame -- possible solution 

            foreach(var player in game.Players)
            {
                for (int i = 0; i < 11; i++)
                {
                    var frame = FrameFactory.RandomFrame();

                    player.PlayerRoll(frame);
                }

            }

            return game; 
           
        }
    }

}
