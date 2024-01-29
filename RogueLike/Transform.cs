namespace RogueLike
{
    internal class Transform
    {
        public int _X { get; set; }
        public int _Y { get; set; }
        public double _direction { get; set; }
        
        public Transform() {
            _X = -1; 
            _Y = -1;
            _direction = -1;
        }
        public Transform(int X, int Y){
            _X = X;
            _Y = Y;
            _direction = 12;
        }
        public Transform(int X, int Y, double direction) {
            _X = X; 
            _Y = Y;
            _direction = direction;
        }

    }
}
