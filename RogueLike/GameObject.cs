namespace RogueLike
{
    internal class GameObject
    {
        static int _nextId;
        public int _GameObjId { get; private set; }
        public Image _img;
        public string _Name;
        public string? _Description;
        public Transform _tForm;
        public Action<Transform, Transform>? Moved;
        public GameObject() { 
            _img = new Image();
            _Name = string.Empty;
            _Description = string.Empty;
            _tForm = new Transform();
            _GameObjId = Interlocked.Increment(ref _nextId);
        }
        public GameObject(char img,
                          string name,
                          string? description,
                          Transform tForm)
        {
            _img = new Image(img);
            _Name = name;
            _Description = description;
            _tForm = tForm;
            _GameObjId = Interlocked.Increment(ref _nextId);
        }

        public void Info() => Console.WriteLine($"ID: {_GameObjId} \nName: {_Name} \nDescription: {_Description} \nPosition: {_tForm._X} : {_tForm._Y}");

        public void WasToched() {
            
        }
        public void MoveTo(Transform tform) {
            Transform _oldForm = _tForm;
            _tForm = tform; 
            Moved?.Invoke(_oldForm, _tForm);
        }
    }
}
