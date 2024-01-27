using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RogueLike
{
    internal class Room
    {
        static int _nextId;
        public int _roomId { get; private set; }
        public int _SizeX;
        public int _SizeY;
        public GameObject[,] _objs;
        public static Action<int, double[]>? Free;
        public Room() {
            _SizeX = 12;
            _SizeY = _SizeX;
            _objs = new GameObject[_SizeX, _SizeY];
            _roomId = Interlocked.Increment(ref _nextId);
            Fill();
        }
        public Room(int SizeX, int SizeY) {
            _SizeX = SizeX < 3 ? 12 : SizeX;
            _SizeY = SizeY < 3 ? 12 : SizeY;
            _objs = new GameObject[_SizeX, _SizeY];
            _roomId = Interlocked.Increment(ref _nextId);
            Fill();
        }

        private void Fill() {
            for (int X = 0; X < _SizeX; X++)
                for (int Y = 0; Y < _SizeY; Y++)
                    _objs[X,Y] = new GameObject();
        }
        public void AddObj(GameObject obj) {
            _objs[obj._tForm._X, obj._tForm._Y] = obj;
            obj.Moved += MoveObj;
        }
        public void DelObj(GameObject obj) {
            _objs[obj._tForm._X, obj._tForm._Y] = new GameObject();
            obj.Moved -= MoveObj;
        }
        private void MoveObj(Transform oldForm, Transform newForm) {
            _objs[newForm._X,newForm._Y] = _objs[oldForm._X, oldForm._Y];
            _objs[oldForm._X, oldForm._Y] = new GameObject();
        }
    }
}
