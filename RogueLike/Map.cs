namespace RogueLike
{
    internal struct Map
    {
        public int _roomCount;
        public Room[] _roomes;
        public Map() {
            _roomCount = 1;
            _roomes = new Room[_roomCount];
            _roomes[0] = new Room();
        }
        public Map(int roomCount) { 
            _roomCount = roomCount;
            _roomes = new Room[_roomCount];
        }
        private void AddRoom(Room room) {
            _roomes[room._roomId] = room;
        }
    }
}
