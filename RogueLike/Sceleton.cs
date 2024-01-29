namespace RogueLike
{
    internal class Sceleton : GameObject
    {
        public Sceleton() {
            _health = new Health();
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
            _tForm = new Transform();
            _damage = 1;
        }
        public Sceleton(Image img,
                        string name,
                        string? description,
                        Transform tForm,
                        Health health,
                        int damage) : base(img, name, description, tForm, health, damage)
        { }

    }
}
