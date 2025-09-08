namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] FibSeq = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            Console.WriteLine("Фиббоначи по порядку с помощью for:");

            for (int i = 0; i < FibSeq.Length; i++)
            {
                Console.WriteLine(FibSeq[i]);
            }

            Console.WriteLine("Чётные до двадцати с помощью for:");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Таблица умножения с помощью вложенного for:"); //Не смог придумать как можно вывести в одну строку умножение на одно число,
                                                                              //а затем вывести в другой строке на другое(если так ваще возможно).

            for (int i = 0; i<=10 ; i++)
            {
                for(int j = 0; j<=10;  j++)
                {
                    Console.WriteLine($"{i} * {j} = {j * i}");
                }

                Console.WriteLine("");
            }


            string password = "qwerty"; ;
            string? checkbox;
            Console.WriteLine("Введите пароль");

            do
            {
                 
                checkbox = Console.ReadLine();
                if( password != checkbox)
                {
                    Console.WriteLine("Неверный пароль!");
                }
                else
                {
                    Console.WriteLine("Добро пожаловать!");
                }
                //Можно ли сделать вывод не через if, else? Как будет попрактичнее? 

            }
            while (password != checkbox);
            
        }
        
    }
}
