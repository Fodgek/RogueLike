namespace RogueLike
{
    internal class GameObject
    {
        static int _nextId = -1;
        public int _GameObjId { get; private set; }
        public Image _img;
        public string _Name;
        public string? _Description;
        public Transform _tForm;
        public Health _health;
        public int _damage;
        public Action<Transform, Transform>? Moved;
        public Action<Image, Transform, int>? Attacked;
        public GameObject() {
            _GameObjId = Interlocked.Increment(ref _nextId);
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
            _tForm = new Transform();
            _health = new Health();
            _damage = 0;
        }
        public GameObject(Image img,
                          string name,
                          string? description,
                          Transform tForm,
                          Health health,
                          int damage)
        {
            _GameObjId = Interlocked.Increment(ref _nextId);
            _img = img;
            _Name = name;
            _Description = description;
            _tForm = tForm;
            _health = health;
            _damage = damage <= 0 ? damage : -damage;
        }

        public void Info() => Console.WriteLine($"ID: {_GameObjId} \nName: {_Name} \nDescription: {_Description} \nPosition: {_tForm._X} : {_tForm._Y} \nDerection: {_tForm._direction} \nHP: {_health._value}");
        public void LowInfo() => Console.WriteLine($"\nName: {_Name} \nHP: {_health._value}");
        public void MoveTo(Transform tform) {
            Transform _oldForm = _tForm;
            _tForm = tform; 
            Moved?.Invoke(_oldForm, _tForm);
        }
        public void Attack(Image img,Transform tForm) => Attacked?.Invoke(img, tForm, _damage);
    }
}
