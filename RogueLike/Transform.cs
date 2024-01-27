namespace RogueLike
{
    internal class Transform
    {
        public int _X { get; set; }
        public int _Y { get; set; }
        //public int _SizeX { get; set; }
        //public int _SizeY {  get; set; }
        
        public Transform() {
            _X = 0; 
            _Y = 0;
            //_SizeX = 1;
            //_SizeY = 1;
        }
        public Transform(int X, int Y) {
            _X = X; 
            _Y = Y;
            //_SizeX = 1;
            //_SizeY = 1;
        }
      /*public Transform(int X, int Y, int SizeX, int SizeY)
        {
            _X = X;
            _Y = Y;
            _SizeX = SizeX;
            _SizeY = SizeY;
        }*/
    }
}
