using Bowling_Score_API.Models;
using System;
using Xunit;

namespace BowlingScoreApITest
{
    public class FrameTests
    {
        [Fact]
        public void IfFrameIsAStrike()
        {

            //arrange 
            var frame = new Frame(1, 10,0);
            //act 
          
                Assert.True(frame.IsAStrike());

            //assert
        }

        [Fact]
        public void IfFrameIsASpare()
        {

            //arrange 
            var frame = new Frame(2, 8, 2);
            //assert
            
                Assert.True(frame.IsASpare());

           

        }
    }
}
