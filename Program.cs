using System;

namespace OBJECTS

{
    class Array
    {
        public static void ArrayObject()
        {
            Console.WriteLine("\nВведите количество элементов массива: \t");
            int ArrNumber = int.Parse(Console.ReadLine());
            int[] array = new int[ArrNumber];

            for (int l = 0; l < ArrNumber; l++)
            {
                Console.Write($"\nВведите число с индексом {l} \t");
                array[l] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write($"\nТаким образом, массив выглядит следующим образом:\n\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine();
            Console.Write($"\nИ теперь наоборот:\n\n");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            
            Console.WriteLine("\nСпасибо за внимание!");
            Console.ReadLine();


        }
    }
    class StatusBar
    {

        public static void AnotherBAR()
        {
            string Status = "$";
            Console.Write("Status bar2: [");

            for (int i = 0; i <= 99; i++)
            {

                for (int n = 0; n < 1500000; n++)
                { }
                Console.Write(Status);

                //Status++;
            }

            Console.Write("100]");
            //Console.ReadLine();

        }

    }
    class Progress
    {
        public static void ProgressBar()
        {
            string Status = "*";
            Console.Write("Status bar1: [");

            for (int i = 0; i <= 99; i++)
            {

                for (int n = 0; n < 1500000; n++)
                { }
                Console.Write(Status);

                //Status++;
            }

            Console.Write("100]");
            Console.WriteLine();
            //Console.ReadLine();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Progress.ProgressBar();
            Console.WriteLine();
            StatusBar.AnotherBAR();
            Console.WriteLine();
            Array.ArrayObject();
        }

    }

}
