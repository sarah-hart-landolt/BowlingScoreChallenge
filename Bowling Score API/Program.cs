using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bowling_Score_API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Bowling_Score_API
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var game = new Game();
            game.PlayGame();
            game.Score();

            foreach(var frameesque in game.Frames)
            {
                Console.WriteLine($"Second roll = {frameesque.SecondRoll}");
                Console.WriteLine($"Total = {frameesque.total}");



            }





        }

    }
}
