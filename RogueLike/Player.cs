using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal class Player : GameObject
    {
        private Health _health;
        public Player() {
            _health = new Health();
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
            _tForm = new Transform();
        }
        public Player(int hp,
                          char img,
                          string name,
                          string? description,
                          Transform tForm,
                          PlayerControls controls) : base(img, name, description, tForm)
        {
            _health = new Health(hp);
        }
        public void HP() => Console.WriteLine(_health._value);
    }
}
