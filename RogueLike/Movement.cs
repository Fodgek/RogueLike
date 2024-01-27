namespace RogueLike
{
    internal class Movement
    {
        public void MoveUp(GameObject obj) {
            
            obj.MoveTo(new Transform(obj._tForm._X - 1,obj._tForm._Y));
        }
        public void MoveUpRight(GameObject obj) {
            obj.MoveTo(new Transform(obj._tForm._X - 1, obj._tForm._Y + 1));
        }
        public void MoveRight(GameObject obj) {
            obj.MoveTo(new Transform(obj._tForm._X, obj._tForm._Y + 1));
        }
        public void MoveDownRight(GameObject obj)
        {
            obj.MoveTo(new Transform(obj._tForm._X + 1, obj._tForm._Y + 1));
        }
        public void MoveDown(GameObject obj) {
            obj.MoveTo(new Transform(obj._tForm._X + 1, obj._tForm._Y));
        }
        public void MoveDownLeft(GameObject obj) {
            obj.MoveTo(new Transform(obj._tForm._X + 1, obj._tForm._Y - 1));
        }
        public void MoveLeft(GameObject obj) {
            obj.MoveTo(new Transform(obj._tForm._X, obj._tForm._Y - 1));
        }
        public void MoveUpLeft(GameObject obj)
        {
            obj.MoveTo(new Transform(obj._tForm._X - 1, obj._tForm._Y - 1));
        }
    }
}
