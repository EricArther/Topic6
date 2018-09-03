using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            Four();
        }

        public static void One()
        {
            string[] medals = new string[3] { "gold", "silver", "bronze" };
            string[] person = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"who is the {medals[i]} winner? ");
                person[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("who do you want to know?");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}: {medals[i]} winner.");
            }

            Console.WriteLine();
            int check = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine();
            Console.WriteLine($"it's {person[check]}");

            Console.ReadKey();
        }

        public static void Two()
        {
            string[] names = new string[5];

            Console.WriteLine("enter five names.");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("enter a name. ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]}");
            }

            Console.ReadKey();
        }

        public static void Three()
        {
            string[] tickets = new string[20];

            for (int i = 0; i < tickets.Length; i++)
            {
                Console.Write($"ticket number {i + 1}: ");
                tickets[i] = Console.ReadLine();
            }

            Random random = new Random();

            Console.WriteLine();
            Console.WriteLine($"the winner is {tickets[random.Next(tickets.Length)]}.");
            Console.WriteLine("Congratulations.");

            Console.ReadKey();
        }

        public static void Four()
        {
            string[] hello = { "kia ora", "Kon'nichiwa", "namaste", "bonjour", "talofa" };
            string[] langs = { "Maori", "Japanese", "Hindi", "French", "Samoan" };

            Console.WriteLine("which language do you want to say hello in?");
            for (int i = 0; i < hello.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {langs[i]}");
            }

            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine();
            Console.WriteLine($"it's {hello[choice]}");

            Console.ReadKey();
        }
    }
}
