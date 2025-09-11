namespace Classes
{
    public class Unit
    {
        private float _health;

        private float _armor;

        private int _damage;
        public string Name { get; }

        public float Health => _health;

        public int Damage { get { return _damage; } set { _damage = 5; } } //Не уверен насчёт того правильным ли способом установил значения для армора и дамага

        public float Armor { get { return _armor; } set { _armor = 0.6f; } }
        public Unit() : this(name:"Uknown Unit")
        {
        }

        public Unit(string name)
        {
            Name = name;
        }

        public float GetRealHealth()
        {
            return  Health * (1f + Armor);
        }

        public bool SetDamage(int value)
        {
            _health = Health - value * Armor;
            if (Health<=0) return true;
            else return false;

        }
       

        

    }
}
