using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace RogueLike
{
    internal class Room
    {
        static int _nextId = -1;
        public int _roomId { get; private set; }
        public int _SizeX;
        public int _SizeY;
        public GameObject[,] _objs;
        public Action<GameObject, bool>? ObjDead;
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
            if (IsObj(obj)) Console.WriteLine("{0} not added", obj._Name);
            else {
                _objs[obj._tForm._X, obj._tForm._Y] = obj;
                obj.Moved += MoveObj;
                obj.Attacked += Damage;
            }
        }
        public void RemoveObj(GameObject obj) {
            obj.Moved -= MoveObj;
            obj.Attacked -= Damage;
            _objs[obj._tForm._X, obj._tForm._Y] = new GameObject();
        }
        public void RemoveObj(Transform tForm) {
            _objs[tForm._X, tForm._Y].Moved -= MoveObj;
            _objs[tForm._X, tForm._Y].Attacked -= Damage;
            _objs[tForm._X, tForm._Y] = new GameObject();
        }

        private void MoveObj(Transform oldForm, Transform newForm) {
            if (IsBorder(newForm))
                _objs[oldForm._X, oldForm._Y]._tForm = new Transform(oldForm._X,oldForm._Y,newForm._direction);
            else if (IsEmpty(newForm))
            {
                _objs[newForm._X, newForm._Y] = _objs[oldForm._X, oldForm._Y];
                _objs[oldForm._X, oldForm._Y] = new GameObject()            ;
            }
            else _objs[oldForm._X, oldForm._Y]._tForm = new Transform(oldForm._X, oldForm._Y, newForm._direction); ;
        }
        private void Damage(Image img, Transform tForm, int amount) {
            if (IsBorder(tForm) == false)
                if(IsEmpty(tForm) == false) {
                    GetObj(tForm)._health.ChangeHealth(amount);
                    if (GetObj(tForm)._health._value <= 0) {
                        RemoveObj(tForm);
                        ObjDead?.Invoke(GetObj(tForm),true);
                    }
                }
        }
        private bool IsBorder(Transform tForm){
            if (tForm._X < 0 || tForm._X > _SizeX - 1 || tForm._Y < 0 || tForm._Y > _SizeY - 1)
                return true;
            else return false;
        }
        private bool IsObj(GameObject obj) {
            if (obj._tForm._X < 0 || obj._tForm._X > _SizeX - 1 || obj._tForm._Y < 0 || obj._tForm._Y > _SizeY - 1)
                return true;
            else return false;
        }
        private bool IsEmpty(Transform tForm) {
            if (_objs[tForm._X,tForm._Y]._img._symbol == new Image()._symbol) return true;
            else return false;
        }
        public bool IsObjWithTag(Transform tForm, string tag)
        {
            if (_objs[tForm._X, tForm._Y]._Name == tag)
                return true;
            else return false;
        }
        public GameObject GetObj(Transform tForm) {
            return _objs[tForm._X, tForm._Y];
        }
    }
}
