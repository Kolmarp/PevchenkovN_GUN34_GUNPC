namespace Memory
{
    public class Unit
    {
        private float _health;

        public string Name { get; }

        public float Health => _health;

        public int Damage { get; } = 5;

        public float Armor { get; } = 0.6f;
        public Unit() : this(name: "Uknown Unit")
        {
        }

        public Unit(string name)
        {
            Name = name;
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(int value)
        {
            _health = Health - value * Armor;
            if (Health <= 0) return true;
            else return false;

        }


    }

    public class Weapon
    {
        public string Name { get; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public float Durability { get; }

        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {

            SetDamageParams(minDamage, maxDamage);
            Durability = 1f; //Очень странно задание написано для прочности, "Значение задаётся в конструкторе и равно 1; тип float"
                             //А сам конструктор не дан, поэтому воткнул сюда, не совсем понятно куда его еще можно засунуть
        }

        public void  SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                Console.WriteLine($"Некорректный ввод данных урона для{Name}");
                MaxDamage = minDamage; 
                MinDamage = maxDamage;                
            }
            else if(minDamage < 1)
            {
                minDamage = 1; //не совсем понял что значит "Если minDamage меньше 1, минимальный урон оружия задается значением f" Откуда f, это сколько в цифрах?
                Console.WriteLine($"Значение для {Name} слишком низкое! Поставлено минимальное(1)");               //По логике поставил просто минимальное допустимое
            }
            else if (maxDamage <=1)
            {
                maxDamage = 10;

            }

                MaxDamage = maxDamage;
                MinDamage = minDamage;
            

        }
        public int GetDamage()
        {
            return (MaxDamage + MinDamage)/2;
        }
    }


}
