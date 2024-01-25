using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal class LiveObject : GameObject
    {
        private Health _health;
        public LiveObject() {
            _health = new Health();
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
            _X = 0; 
            _Y = 0; 
        }
        public LiveObject(int hp,
                          char img,
                          string name,
                          string? description,
                          int X,
                          int Y) : base(img, name, description, X, Y)
        {
            _health = new Health(hp);
        }
    }
}
