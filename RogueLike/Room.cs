using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike
{
    internal struct Room
    {
        public int _SizeX;
        public int _SizeY;
        public GameObject[,] _objArr;
        public Room() {
            _SizeX = 12;
            _SizeY = _SizeX;
            _objArr = new GameObject[_SizeX, _SizeY];
            Walls();
        }
        public Room(int SizeX, int SizeY) {
            _SizeX = SizeX < 3 ? 12 : SizeX;
            _SizeY = SizeY < 3 ? 12 : SizeY;
            _objArr = new GameObject[_SizeX, _SizeY];
            Walls();
        }
        
        public void AddObj(GameObject obj) => _objArr[obj._X, obj._Y] = obj;
        public void DelObj(GameObject obj) => _objArr[obj._X, obj._Y] = new GameObject();
        public void MoveObj(GameObject obj) {
            
        }
        private void Walls() {
            char wall_img = '#';
            string wall_name = "Wall";
            string wall_description = "Wall of Room";

            for (int X = 0; X < _SizeX; X++) 
                for (int Y = 0; Y < _SizeY; Y++) {
                    _objArr[X, Y] = new GameObject();
                    _objArr[0, Y] = new GameObject(wall_img, wall_name, wall_description, 0, Y);
                    _objArr[X, 0] = new GameObject(wall_img, wall_name, wall_description, X, 0);
                    _objArr[_SizeX - 1, Y] = new GameObject(wall_img, wall_name, wall_description, _SizeX - 1, Y);
                    _objArr[X, _SizeY - 1] = new GameObject(wall_img, wall_name, wall_description, X, _SizeY - 1);
                }
        }
    }
}
