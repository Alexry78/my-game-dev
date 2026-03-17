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
            Console.WriteLine($"Game started with difficulty: {Difficulty}");
            Console.WriteLine($"Map size: {MapWidth} x {MapHeight}");
            Console.WriteLine("Press SPACE to spawn an enemy, ESC to exit...");

            Player player = new Player { Name = "Hero", Health = 100 };
            Map map = new Map(MapWidth, MapHeight);

            List<EnemyFactory> factories = new List<EnemyFactory>
            {
                new OrcFactory(),
                new GoblinFactory()
            };

            Random random = new Random();
            string lastMessage = "No events yet.";

            bool isRunning = true;
            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                        isRunning = false;
                    else if (key == ConsoleKey.Spacebar)
                    {
                        int index = random.Next(factories.Count);
                        EnemyFactory factory = factories[index];
                        Enemy enemy = factory.CreateEnemy();
                        lastMessage = $"Spawned: {enemy.Name} (HP {enemy.Health})";
                        enemy.Attack(player);
                        lastMessage += $" | Player health: {player.Health}";
                    }
                }

                Console.Clear();
                Console.WriteLine($"Player: {player.Name} | Health: {player.Health}");
                Console.WriteLine($"Map: {map.Width}x{map.Height}");
                Console.WriteLine($"Last event: {lastMessage}");
                Console.WriteLine("Press SPACE to spawn an enemy, ESC to exit...");

                System.Threading.Thread.Sleep(50);
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