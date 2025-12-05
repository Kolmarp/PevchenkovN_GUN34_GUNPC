using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Варианты задач:");
            Console.WriteLine("1. Работа со списком");
            Console.WriteLine("2. Работа со студентами");
            Console.WriteLine("3. Работа с двусвязным списком");
            Console.WriteLine("Выберите номер задачи:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListEdit task1 = new ListEdit();
                    task1.TaskLoop();
                    break;

                case "2":
                    StudentGroup task2 = new StudentGroup();
                    task2.TaskLoop();
                    break;

                case "3":
                    TwoNodes task3 = new TwoNodes();
                    task3.TaskLoop();
                    break;


                default:
                    Console.WriteLine("Задача с таким номером не найдена.");
                    break;
            }


        }

        internal class ListEdit
        {
            public void TaskLoop()
            {
                Console.WriteLine("Задача 1");
                Console.WriteLine("Для выхода из задачи введите '--exit' в любом запросе на ввод.");


                List<string> listedit = new List<string>();

                listedit.Add("a");
                listedit.Add("b");
                listedit.Add("c");
                Console.WriteLine("Начальный Список:");
                PrintList(listedit);


                Console.WriteLine("Введите элемент в конец списка");
                string UserInput = Console.ReadLine();

                if (UserInput == "--exit") return;

                listedit.Add(UserInput);

                Console.WriteLine("Список с добавленным в конце элементом:");
                PrintList(listedit);

                Console.WriteLine("Введите элемент в середину");
                UserInput = Console.ReadLine();

                if (UserInput == "--exit") return;

                int MidIndex = listedit.Count / 2;

                listedit.Insert(MidIndex, UserInput);

                Console.WriteLine($"Элемент добавлен на строку {MidIndex + 1}");
                Console.WriteLine("Список:");
                PrintList(listedit);

                Console.WriteLine("Задача  завершена. Нажмите любую клавишу для выхода...");
                Console.ReadKey();






            }

            private static void PrintList(List<string> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }

            }
        }

        internal class StudentGroup
        {
            public void TaskLoop()
            {
                var groupgrades = new Dictionary<string, int>();
                groupgrades.Add("Иванов", 3);
                groupgrades.Add("Андреев", 5);
                groupgrades.Add("Сизов", 4);
                groupgrades.Add("Приколов", 4);

                Console.Write("Введите Фамилию студента:");
                string nameInput = Console.ReadLine();

                if (nameInput == "--exit") return;

                Console.WriteLine("Введите оценку студента (2-5):");
                int gradeInput = int.Parse(Console.ReadLine());

                if (gradeInput < 2 || gradeInput > 5)
                {

                    Console.WriteLine("Оценка недопустима");
                    return;
                }
                groupgrades.Add(nameInput, gradeInput);
                Console.WriteLine($"Студент {nameInput} с оценкой {gradeInput} Добавлен");

                Console.WriteLine("Чтобы проверить оценку студента, введите фамилию, для выхода --exit");
                nameInput = Console.ReadLine();
                if (nameInput == "--exit")
                    return;
                if (groupgrades.TryGetValue(nameInput, out int grade))
                {
                    Console.WriteLine($"Студент {nameInput} имеет оценку {grade}");
                }

                else
                {
                    Console.WriteLine($"Студент с именем {nameInput} не найден.");
                }



            }


        }

        internal class TwoNodes
        {
            
            internal class Node
            {
                public string Value;
                public Node Prev;
                public Node Next;
            }

            
            private class DoubleLinkedList
            {
                private Node head;
                private Node tail;
                private int count;

                public void Add(string value)
                {
                    Node newNode = new Node { Value = value };

                    if (head == null) 
                    {
                        head = newNode;
                        tail = newNode;
                    }
                    else 
                    {
                        tail.Next = newNode;
                        newNode.Prev = tail;
                        tail = newNode;
                    }
                    count++;
                }

                public void DisplayForward()
                {
                    Node current = head;
                    while (current != null)
                    {
                        Console.Write(current.Value + " <-> ");
                        current = current.Next;
                    }
                    Console.WriteLine("null");
                }

                public void DisplayBackward()
                {
                    Node current = tail;
                    while (current != null)
                    {
                        Console.Write(current.Value + " <-> ");
                        current = current.Prev;
                    }
                    Console.WriteLine("null");
                }
            }

            public void TaskLoop()
            {
                DoubleLinkedList list = new DoubleLinkedList();

                Console.WriteLine("Создайте двусвязный список (3-6 элементов):");

                for (int i = 0; i < 6; i++) 
                {
                    Console.Write($"Элемент {i + 1}: ");
                    string element = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(element))
                    {
                        list.Add(element);

                        if (i >= 2) 
                        {
                            if (i < 5) 
                            {
                                Console.Write("Добавить еще? (да/нет): ");
                                if (Console.ReadLine().ToLower() != "да")
                                    break;
                            }
                        }
                    }
                }

                Console.WriteLine("Список в прямом порядке:");
                list.DisplayForward();

                Console.WriteLine("Список в обратном порядке:");
                list.DisplayBackward();
            }

        }

    }
}
           

