
namespace Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Dungeon = new Dungeon();
            Dungeon.ShowRooms();

        }
    }
    public struct Interval
    {
        private static Random _randomizer = new Random();

        public int Min { get; }
        public int Max { get; }
        public int Get => _randomizer.Next(Min, Max + 1);

        public Interval(int minValue, int maxValue)
        {

            if (minValue > maxValue)
            {
                Console.WriteLine("Некорректный ввод данных! Границы поменяны местами.");
                (minValue, maxValue) = (maxValue, minValue);
            }

            else if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Минимальная граница установлена в 0.");
            }

            else if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Максимальная граница установлена в 0.");
            }

            else if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Максимальная граница увеличена на 10.");
            }

            Min = minValue;
            Max = maxValue;
        }
    }


    public class Unit
    {
        private float _health = 100f;

        private Interval _damageInterval;
        public string Name { get; }

        public float Health => _health;
        
        public int Damage => _damageInterval.Get;

        
        public Interval DamageInterval => _damageInterval;

        public float Armor { get; } = 0.6f;

       
        public Unit() : this( "Uknown Unit", 0, 5)
        {
        }

        public Unit(string name,int maxDamage): this(name,0, maxDamage) 
        {       
        }

        public Unit(string name,int minDamage, int maxDamage)
        {
            Name = name;
            _damageInterval = new Interval(minDamage, maxDamage);
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
        public float Durability { get; }
        
        public Interval DamageInterval { get; }
        
        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
            DamageInterval = new Interval(1, 5);

        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
           DamageInterval = new Interval(minDamage, maxDamage);
        }

        

    }

    

    public class Dungeon
    {
        struct Room
        {
            public Unit Unit { get;}


            public Weapon Weapon { get;}


            public Room(Unit unit, Weapon weapon)
            {
                Unit = unit;
                Weapon = weapon;
            }
        }
        private Room[] _rooms;
      
        
        public Dungeon()
        {
            Room[] rooms = new Room[]
            {
                new Room(new Unit("Skeleton",4),new Weapon("Bow",3, 6)),
                new Room(new Unit("Warrior",4),new Weapon("GreatSword",4, 7)),
                new Room(new Unit("Zombie",4),new Weapon("Sword",1, 3)),
                new Room(new Unit("Boss",4),new Weapon("Gun",6, 9))
            };
            _rooms = rooms;
        }



        public void ShowRooms()
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                var room = _rooms[i];

                Console.WriteLine($"Room {i + 1}:");
                Console.WriteLine($"Unit: {room.Unit.Name}, Damage: {room.Unit.Damage}");
                Console.WriteLine($"Weapon: {room.Weapon.Name}, MinDamage: {room.Weapon.DamageInterval.Min}, MaxDamage: {room.Weapon.DamageInterval.Max}");
                Console.WriteLine("—");
            }
        }



}   }     
