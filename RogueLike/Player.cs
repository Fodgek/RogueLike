namespace RogueLike
{
    internal class Player : GameObject
    {
        public Player() {
            _health = new Health();
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
            _tForm = new Transform();
            _damage = 1;
        }
        public Player(Image img,
                      string name,
                      string? description,
                      Transform tForm,
                      Health health,
                      int damage) : base(img, name, description, tForm, health, damage)
        { }
    }
}
