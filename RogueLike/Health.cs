namespace RogueLike
{
    internal class Health
    {
        public int _value { get; set; }
        public Health() => _value = 0;
        public Health(int value) => _value = value;
        public void ChangeHealth(int value) => _value += value;   
    }
}
