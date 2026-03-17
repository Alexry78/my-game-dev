using System;
using System.Collections.Generic;
using MyGameApp.Entities;

namespace MyGameApp.Core
{
    public class GameManager
    {
        // Единственный экземпляр (поле static)
        private static GameManager _instance;

        // Приватный конструктор — предотвращает создание через new
        private GameManager()
        {
            // Инициализация настроек по умолчанию
            MapWidth = 10;
            MapHeight = 10;
            Difficulty = DifficultyLevel.Medium;
        }

        // Глобальная точка доступа (свойство)
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameManager();
                }
                return _instance;
            }
        }

        // Настройки игры (можно будет менять через Instance)
        public int MapWidth { get; set; }
        public int MapHeight { get; set; }
        public DifficultyLevel Difficulty { get; set; }

        // Игровой цикл (перенесём сюда)
        public void Run()
        {
            // Приветствие с настройками
            Console.WriteLine($"Game started with difficulty: {Difficulty}");
            Console.WriteLine($"Map size: {MapWidth} x {MapHeight}");
            Console.WriteLine("Press ESC to exit...");

            // Создаём игрока и карту (можно позже перенести в конструктор)
            Player player = new Player { Name = "Hero", Health = 100 };
            Map map = new Map(MapWidth, MapHeight);

            bool isRunning = true;
            while (isRunning)
            {
                // Обновление логики (пока пусто)
                // Отрисовка (упрощённо)
                Console.Clear();
                Console.WriteLine($"Player: {player.Name} | Health: {player.Health}");
                Console.WriteLine($"Map: {map.Width}x{map.Height}");
                Console.WriteLine("Press ESC to exit...");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                        isRunning = false;
                }

                System.Threading.Thread.Sleep(50);
            }
        }
    }

    // Enum для уровня сложности (можно поместить в отдельный файл или в этот же)
    public enum DifficultyLevel
    {
        Easy,
        Medium,
        Hard
    }
}
