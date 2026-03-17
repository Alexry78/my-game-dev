using System;
using System.Collections.Generic;
using MyGameApp.Entities;

namespace MyGameApp.Core
{
    public class GameManager
    {
        private static GameManager _instance;
        private GameManager()
        {
            MapWidth = 10;
            MapHeight = 10;
            Difficulty = DifficultyLevel.Medium;
        }

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameManager();
                return _instance;
            }
        }

        public int MapWidth { get; set; }
        public int MapHeight { get; set; }
        public DifficultyLevel Difficulty { get; set; }

        public void Run()
        {
            Console.WriteLine("Debug mode: press any key to see its code, ESC to exit.");

            bool isRunning = true;
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);
                    var key = keyInfo.Key;
                    Console.WriteLine($"Key pressed: {key} (char: {keyInfo.KeyChar})");

                    if (key == ConsoleKey.Escape)
                        isRunning = false;
                    else if (key == ConsoleKey.Spacebar)
                    {
                        Console.Beep();
                        Console.WriteLine("SPACE detected!");
                    }
                }
            }
        }
    }

    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }
}