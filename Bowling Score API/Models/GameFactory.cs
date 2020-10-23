using System;


namespace Bowling_Score_API.Models
{
    public class GameFactory
    {
        private static readonly Random rnd = new Random();

        public Game BuildGameFactory()
        { 
            var game =  new Game();
            var randomPlayer = new PlayerFactory();


            for (int i = 0; i < rnd.Next(1, 5); i++)
            {

                var player1 = randomPlayer.RandomPlayer();
                    game.addPlayer(player1);

            }



            ///possible cleanup instead of having 11 frames: player.isLastRollStrike, if so add frame -- possible solution 

            foreach (var player in game.Players)
            {
                for (int i = 0; i < 11; i++)
                {
                    var frame = FrameFactory.RandomFrame();
                    //var frame2 = FrameFactory.RandomFrame();

                    player.PlayerRoll(frame);
                    //if(i == 9 && frame.IsAStrike())
                    //{
                    //    player.PlayerRoll(frame2);
                    //}
                }
            }

            game.GameScore();
            return game; 
           
        }


    }

}
