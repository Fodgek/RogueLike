namespace RogueLike
{
    internal struct Map
    {
        public int _roomCount;
        public Room[] _roomes;
        public Map() {
            _roomCount = 2;
            _roomes = new Room[_roomCount];
        }
        public Map(int roomCount) { 
            _roomCount = roomCount;
            _roomes = new Room[_roomCount];
        }
        private void CreateRoom() {
            for (int num = 0; num < _roomCount; num++) 
                _roomes[num] = new Room();
        }
    }
}
