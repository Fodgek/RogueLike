using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal struct Map
    {
        public int _SizeX ;
        public int _SizeY ;
        public Map() {
            _SizeX = 101;
            _SizeY = 101;
        }
        public Map(int SizeX, int SizeY) { 
            _SizeX = SizeX; 
            _SizeY = SizeY;
        }
        public void CreateMap() {
            Console.SetCursorPosition(1, 1);
        }
    }
}
