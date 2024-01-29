namespace RogueLike
{
    abstract class GameObjectBehaviour
    {
        public static void MoveUp(GameObject obj) =>        obj.MoveTo(new Transform(obj._tForm._X - 1, obj._tForm._Y    , 12.0));
        public static void MoveUpRight(GameObject obj) =>   obj.MoveTo(new Transform(obj._tForm._X - 1, obj._tForm._Y + 1, 1.5));
        public static void MoveRight(GameObject obj) =>     obj.MoveTo(new Transform(obj._tForm._X    , obj._tForm._Y + 1, 3.0));
        public static void MoveDownRight(GameObject obj) => obj.MoveTo(new Transform(obj._tForm._X + 1, obj._tForm._Y + 1, 4.5));
        public static void MoveDown(GameObject obj) =>      obj.MoveTo(new Transform(obj._tForm._X + 1, obj._tForm._Y    , 6.0));

        public static void MoveDownLeft(GameObject obj) =>  obj.MoveTo(new Transform(obj._tForm._X + 1, obj._tForm._Y - 1, 7.5));
        public static void MoveLeft(GameObject obj) =>      obj.MoveTo(new Transform(obj._tForm._X    , obj._tForm._Y - 1, 9.0));
        public static void MoveUpLeft(GameObject obj) =>    obj.MoveTo(new Transform(obj._tForm._X - 1, obj._tForm._Y - 1, 10.5));
        public static void Attack(GameObject obj) =>        obj.Attack(ImgForDirection(obj._tForm), tFormFromDirection(obj._tForm));
        private static Image ImgForDirection(Transform tForm) {
            if (tForm._direction == 12.0 || tForm._direction == 6.0) return new Image('*');
            else if (tForm._direction == 3.0 || tForm._direction == 9.0) return new Image('*');
            else if (tForm._direction == 1.5 || tForm._direction == 7.5) return new Image('*');
            else if (tForm._direction == 4.5 || tForm._direction == 10.5) return new Image('*');
            else return new Image();
        }
        private static Transform tFormFromDirection(Transform tForm) {
            if (tForm._direction == 12.0)       return new Transform(tForm._X - 1, tForm._Y    );
            else if (tForm._direction == 1.5)   return new Transform(tForm._X - 1, tForm._Y + 1);
            else if (tForm._direction == 3.0)   return new Transform(tForm._X    , tForm._Y + 1);
            else if (tForm._direction == 4.5)   return new Transform(tForm._X + 1, tForm._Y + 1);
            else if (tForm._direction == 6.0)   return new Transform(tForm._X + 1, tForm._Y    );
            else if (tForm._direction == 7.5)   return new Transform(tForm._X + 1, tForm._Y - 1);
            else if (tForm._direction == 9.0)   return new Transform(tForm._X    , tForm._Y - 1);
            else if (tForm._direction == 10.5)  return new Transform(tForm._X - 1, tForm._Y - 1);
            else return tForm;
        }
    }
}
