using System;
using System.Collections.Generic;
using MyGameApp.Entities;

namespace MyGameApp.Core
{
    public class Game
    {
        private bool _isRunning = true;
        private Player _player;
        private Map _map;
        private List<Enemy> _enemies;

        public Game()
        {
            _player = new Player { Name = "Hero", Health = 100 };
            _map = new Map(10, 10);
            _enemies = new List<Enemy>();
        }

        public void Run()
        {
            while (_isRunning)
            {
                Update();
                Draw();

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                        _isRunning = false;
                }

                System.Threading.Thread.Sleep(50);
            }
        }

        private void Update()
        {
            // Здесь будет обновление логики
        }

        private void Draw()
        {
            Console.Clear();
            Console.WriteLine($"Игрок: {_player.Name} | Здоровье: {_player.Health}");
            Console.WriteLine($"Карта: {_map.Width}x{_map.Height}");
            Console.WriteLine("Нажмите ESC для выхода...");
        }
    }
}
