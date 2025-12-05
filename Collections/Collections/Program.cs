namespace Collections
{
    internal class Program
    {

        
        static void Main(string[] args) 
        {
        
        
        
        
        }

        internal class ListEdit
        {
           static void TaskLoop()
            {
                Console.WriteLine("Задача 1");
                Console.WriteLine("Для выхода из задачи введите '--exit' в любом запросе на ввод.");


                List <string> listedit = new List <string> ();

                listedit.Add ("a");
                listedit.Add ("b");
                listedit.Add ("c");
                Console.WriteLine("Начальный Список:");
                PrintList (listedit);


                Console.WriteLine("Введите символ в конец списка");
                string UserInput = Console.ReadLine();

                if (UserInput == "--exit") return;

                listedit.Add(UserInput);

                Console.WriteLine("Список с добавленным в конце символом:");
                PrintList(listedit);

                Console.WriteLine("Введите символ в середину");
                UserInput = Console.ReadLine();

                Console.WriteLine("Введите символ в середину списка");





            }

            private static void PrintList(List<string> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }
            
            }
        }
    }
           
}
