namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] FibSeq = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            string[] Months = new string [] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
           
            //Не совсем понял что хотят с матрицами, поэтому решил сделать возведение в степень своими руками, и руками C# 
            // (зачем вообще не объясняя что такой инструмент как возведение в степень есть, давать задание на его использование)
           
            int[,] matrix = new int[3, 3] { { 2, 3, 4 }, { 4, 9, 16 }, { 8, 27, 64 } };
            int[,] matrix2 = new int[3, 3];

            matrix2[0, 0] = (int)Math.Pow(2, 1);
            matrix2[0, 1] = (int)Math.Pow(3, 1);
            matrix2[0, 2] = (int)Math.Pow(4, 1);

            matrix2[1, 0] = (int)Math.Pow(matrix2[0, 0], 2);
            matrix2[1, 1] = (int)Math.Pow(matrix2[0, 1], 2);
            matrix2[1, 2] = (int)Math.Pow(matrix2[0, 2], 2);

            matrix2[2, 0] = (int)Math.Pow(matrix2[0, 0], 3);
            matrix2[2, 1] = (int)Math.Pow(matrix2[0, 1], 3);
            matrix2[2, 2] = (int)Math.Pow(matrix2[0, 2], 3);

            double[][] JaggedArray = new double [3][];
            
            JaggedArray [0] = new double[] {1, 2, 3, 4, 5};
            JaggedArray [1] = new double[] { Math.E, Math.PI };
            JaggedArray[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

           
            //5 и 6 задания Ниже

            int[] array = { 1, 2, 3, 4, 5 }; 
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            

            Array.Copy(array, array2, 3);

            Console.WriteLine("Содержимое массива array2: " + string.Join(", ", array2));
            //Очень странно что в шаблоне вообще использовали структуру var result = CopyArrays(array, array2, 2); Такого метода не существует, а Array.Copy нельзя присвоить к var,
            //из-за чего догадаться как вывести массив мне должен помогать Deepseek. Хотя ранее в доп. Материале и был пример с помощью цикла for, но почему я должен его бездумно копировать сюда
            //Почему бы не научить меня циклам, а после массивы давать? Странно короче.

            Array.Resize(ref array, array.Length * 2); //Было бы хорошо если бы мне пояснили что такое ref лучше чем в домашке "Массив передаётся через ref.
                                                       //Это же ключевое слово вы будете использовать при вызове метода Resize" Ваще мне ниче не даёт это,
                                                       //что такое ref, и что будет если я его не буду использовать?

            Console.WriteLine("Увеличенный массив array2: " + string.Join(", ", array));


           
            





        }
    }
}
