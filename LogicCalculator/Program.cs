namespace LogicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a and b, then operation symbol ( |, &, ^)");

            if (!Int32.TryParse(Console.ReadLine(), out var a))
            { 
                Console.WriteLine("Not a number");
                return;
            }

            if (!Int32.TryParse(Console.ReadLine(), out var b))
            {
                Console.WriteLine("Not a number");
                return;
            }

            //var s = Console.ReadLine();

            //if (s.Length == 0 || s.Length > 1)
            //{

            //    Console.WriteLine("Symbol must be singular!");
            //    return;

            //}

            var s = Console.ReadKey().KeyChar;
            switch (s)

            {
                case '|':
                    Console.WriteLine("\nResult of {0} | {1} = {2}", a, b, a | b);
                    Console.WriteLine("Result of {0} | {1} in bynary {2}", a, b, Convert.ToString(a | b, 2));
                    Console.WriteLine("Result of {0} | {1} in hexadecimal {2}", a, b, Convert.ToString(a | b, 16));

                    break;
                
                case '^':
                    Console.WriteLine("\nResult of {0} ^ {1} = {2}", a, b, a ^ b);
                    Console.WriteLine("Result of {0} ^ {1} in bynary {2}", a, b, Convert.ToString(a ^ b, 2));
                    Console.WriteLine("Result of {0} ^ {1} in hexadecimal {2}", a, b, Convert.ToString(a ^ b, 16));

                    break;
                
                case '&':
                    Console.WriteLine("\nResult of {0} & {1} = {2}", a, b, a & b);
                    Console.WriteLine("Result of {0} & {1} in bynary {2}", a, b, Convert.ToString(a & b, 2));
                    Console.WriteLine("Result of {0} & {1} in hexadecimal {2}", a, b, Convert.ToString(a & b, 16));

                    break;

                default:
                    Console.WriteLine("\nThis is an invalid symbol!");
                    break;

            }

        }
    }
}
