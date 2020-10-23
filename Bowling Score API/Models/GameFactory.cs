using System;


namespace Bowling_Score_API.Models
{
    public class GameFactory
    {
        private static readonly Random rnd = new Random();

        public Game BuildGameFactory()
        { 
            var game =  new Game();
            var playerFactory = new PlayerFactory();


            for (int i = 0; i < rnd.Next(1, 6); i++)
            {

                var randomPlayer = playerFactory.RandomPlayer();
               
                    game.addPlayer(randomPlayer);
                // remove player's name from list to avoid duplicates of random generator 
                    playerFactory.players.Remove(randomPlayer.DisplayName);



            }



            ///possible cleanup instead of having 11 frames: player.isLastRollStrike, if so add frame -- possible solution 

            foreach (var player in game.Players)
            {
                for (int i = 0; i < 11; i++)
                {
                    var frame = FrameFactory.RandomFrame();

                    player.PlayerRoll(frame);
               
                }
            }

            game.GameScore();
            return game; 
           
        }


    }

}
