using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal class Game
    {
        public GameSettings _Settings;
        private bool _game;
        private Room _room = new Room();
        public Game() {
            _Settings = new GameSettings();
        }
        public Game(GameSettings settings) {
            _Settings = settings;
        }
        public void GameStart() {
            _game = true;
            while (_game) {
                _Settings._render.RenderFrame(_room);
            }
        }
        public void GameStop() => _game = false;
    }
}
