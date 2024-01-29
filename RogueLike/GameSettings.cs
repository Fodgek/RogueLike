namespace RogueLike
{
    internal class GameSettings
    {
        public Int32 _WindowHeight;
        public Int32 _WindowWidth;
        public Renderer _render;
        public int _RoomCount;
        public PlayerControls _PlayerControls;
        public Image _PlayerImage;
        public string _PlayerName;
        public string _PlayerDescription;
        public int _PlayerHP;
        public int _PlayerDmg;
        public GameSettings() {
            _WindowHeight = 200;
            _WindowWidth = 200;
            _render = new Renderer();
            _RoomCount = 1;
            _PlayerControls = new PlayerControls();
            _PlayerImage = new Image('$');
            _PlayerName = "Player";
            _PlayerDescription = "Игрок";
            _PlayerHP = 5;
            _PlayerDmg = 1;
        }
    }
}
