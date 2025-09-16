
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

    public class Interval
    {
        private Random _randomizer = new Random();

        public int Min { get; set; }
        public int Max { get; set; }
        public int Get { get; set; }
        public void SetDamageParams(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                Console.WriteLine("Некорректный ввод данных!");

                (minValue, maxValue) = (maxValue, minValue);

            }
            else if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Значение слишком низкое! Поставлено минимальное(0)");
            }
            else if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Значение слишком низкое! Поставлено минимальное(0)");
            }
            else if (maxValue == minValue)
            {
                maxValue = 10;
                Console.WriteLine("Максимальное значение должно быть больше минимального!");
            }

            Max = maxValue;
            Min = minValue;

            _randomizer = new Random();

            Get = _randomizer.Next(Min, Max);

        }
    }
    public class Unit
    {
        private float _health;

        public string Name { get; }

        public float Health => _health;

        private Random _randomizer = new Random();

        public int Damage { get; set; }      
        public float Armor { get; } = 0.6f;
        public Unit() : this(name: "Uknown Unit", 0)
        {
        }

        public Unit(string name, int Value)
        {
            Name = name;
            SetUnitDamage(Value);
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

        public void SetUnitDamage(int maxValue)//"Также добавляется вместо свойства Damage у Unit.                                                                                           
        {     //При этом минимальное значение должно быть равно 0" Вот это меня путает, потому что просят сделать метод с двумя числами на ввод,            
            Interval interval = new Interval();

            interval.SetDamageParams(0, maxValue);

            Damage = interval.Get;

        }

    }

    public class Weapon
    {
        public string Name { get; }
        public float Durability { get; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            Interval interval = new Interval();
            interval.SetDamageParams(minDamage, maxDamage);
            Durability = 1f; //Очень странно задание написано для прочности, "Значение задаётся в конструкторе и равно 1; тип float"
                             //А сам конструктор не дан, поэтому воткнул сюда, не совсем понятно куда его еще можно засунуть
            Min = interval.Min;
            Max = interval.Max;

        }

        

    }

    public class Room
    {
        
        public Unit Unit { get; set; }

      
        public Weapon Weapon { get; set; }

        
        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;    
            Weapon = weapon; 
        }
    }

    public class Dungeon
    {
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
                Console.WriteLine($"Weapon: {room.Weapon.Name}, MinDamage: {room.Weapon.Min}, MaxDamage: {room.Weapon.Max}");
                Console.WriteLine("—");
            }
        }



}   }     
