using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
            Two();
            Three();
            Four();
        }

        public static void One()
        {
            int[] reverse = new int[5];

            Console.WriteLine("give me 5 numbers.");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("give a number. ");
                reverse[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 4; i >= 0; i--)
            {
                Console.Write($"{reverse[i]} ");
            }

            Console.ReadKey();
        }

        public static void Two()
        {
            Console.Write("how many numbers do you want? ");
            int[] sums = new int[int.Parse(Console.ReadLine())];

            int sum = 0;
            for (int i = 0; i < sums.Length; i++)
            {
                Console.Write("give me a number. ");
                sums[i] = int.Parse(Console.ReadLine());
                sum += sums[i];
            }

            Console.WriteLine();

            Console.Write("number entered: ");
            for (int i = 0; i < sums.Length; i++)
            {
                Console.Write($"{sums[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"sums of numbers: {sum}");

            Console.ReadKey();
        }

        public static void Three()
        {

            int[] first = new int[5];

            Console.WriteLine("give me 5 numbers.");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("give a number. ");
                first[i] = int.Parse(Console.ReadLine());
            }

            int[] second = first;

            Console.Write("copied: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{second[i]} ");
            }

            Console.ReadKey();

        }

        public static void Four()
        {
            int[] numbers = new int[5];

            Console.WriteLine("give me 5 numbers.");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("give a number. ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = numbers[0];
            int max = numbers[0];

            for(int i = 1; i < 5; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                else if (numbers[i] > max) max = numbers[i];
            }

            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
            Console.ReadKey();


        }
    }
}
