using System;
using System.IO;

namespace GenerateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of values you want generated!");
            Random random = new Random();

            int n = Convert.ToInt32(Console.ReadLine());
            string fileName = n + "numbers.txt";
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (int value in array)
                    sw.WriteLine(value);
            }

            //using (StreamWriter writer = new StreamWriter("../../../NumGenerated/fileName.txt"))
            //{
            //    foreach (int value in array)
            //        writer.WriteLine(value);
            //}
        }
    }
}