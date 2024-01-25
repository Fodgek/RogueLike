using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal class GameObject
    {
        public Image _img { get; set; }
        public string _Name { get; set; }
        public string? _Description { get; set; }
        public int _X { get; set; }
        public int _Y { get; set; }
        public static Action<int,int> ?PosChanged;

        public GameObject() { 
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
        }
        public GameObject(char img,
                          string name,
                          string? description,
                          int X,
                          int Y)
        {
            _img = new Image(img);
            _Name = name;
            _Description = description;
            _X= X;
            _Y= Y;
        }

        public void IAm() {
            if (_Description == null)
            { Console.WriteLine($"I am: {_Name}"); }
            else 
            { Console.WriteLine($"I am: {_Name} \nDescription: {_Description}"); }
        }
        public void MoveTo(int X, int Y) {
            _X = X;
            _Y = Y;
            PosChanged?.Invoke(_X,_Y);
        }
        public void WasToched() {
            
        }

    }
}
