using Bowling_Score_API.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace BowlingScoreApITest
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerBowlingScore()
        {

            //arrange 
            var player = new Player();
            //act 
            player.PlayerRoll();
            player.BowlingCardScore();
            //assert
        }

 

    }
}
