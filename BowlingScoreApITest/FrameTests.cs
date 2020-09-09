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
            var frame = new Frame();
            //act 
            if (frame.FirstRoll == 10)
            {
                Assert.True(frame.IsAStrike());

            } else
            {
                Assert.False(frame.IsASpare());
            }
            //assert
        }

        [Fact]
        public void IfFrameIsASpare()
        {

            //arrange 
            var frame = new Frame();
            //assert
            if (frame.FirstRoll != 10 && frame.total == 10)
            {
                Assert.True(frame.IsASpare());

            }
            else
            {
                Assert.False(frame.IsASpare());
            }

        }
    }
}
