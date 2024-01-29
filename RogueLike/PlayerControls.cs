using System.Windows.Input;

namespace RogueLike
{
    internal class PlayerControls : GameObjectBehaviour
    {
        public ConsoleKey _Up {  get; private set; }
        public ConsoleKey _Down { get; private set; }
        public ConsoleKey _Left { get; private set; }
        public ConsoleKey _Right { get; private set; }
        public ConsoleKey _Attack { get; private set; } 
        public void SetUp(ConsoleKey key) => _Up = key;
        public void SetDown(ConsoleKey key) => _Down = key;
        public void SetLeft(ConsoleKey key) => _Left = key;
        public void SetRight(ConsoleKey key) => _Right = key;
        public void SetAttack(ConsoleKey key) => _Attack = key;
        public PlayerControls() {
            _Up = ConsoleKey.UpArrow; 
            _Down = ConsoleKey.DownArrow;
            _Left = ConsoleKey.LeftArrow;
            _Right = ConsoleKey.RightArrow;
            _Attack = ConsoleKey.Enter;
        }
        public PlayerControls(ConsoleKey up,
                              ConsoleKey down,
                              ConsoleKey left,
                              ConsoleKey right,
                              ConsoleKey attack)
        {
            _Up = up;
            _Down = down;
            _Left = left;
            _Right = right;
            _Attack = attack;
        }
        public void Control(GameObject obj) {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == _Up) MoveUp(obj);
            else if (keyInfo.Key == _Down) MoveDown(obj);
            else if (keyInfo.Key == _Left) MoveLeft(obj);
            else if (keyInfo.Key == _Right) MoveRight(obj);
            else if (keyInfo.Key == _Attack) Attack(obj);
        }

    }
}
