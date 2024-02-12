using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Project3
    {
        static Random random = new Random();
        public static void Main(string[] args)
        {
            List<char> password = new List<char>();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', };

            char[] symbols = { '@', '_', '-', '&', '*', '^', '$', '%', '#' };

            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine("Welcome to the password generator!");
            Console.Write("How many letters would you like? ");

            int letter = Convert.ToInt32(Console.ReadLine());
            Randomizer(letter, letters, password);

            Console.Write("How many symbols would you like? ");

            int symbol = Convert.ToInt32(Console.ReadLine());
            Randomizer(symbol, symbols, password);

            Console.Write("How many numbers would you like? ");

            int num = Convert.ToInt32(Console.ReadLine());
            Randomizer(num, numbers, password);

            password = password.OrderBy(c => random.Next()).ToList();

            string passwordFinal = new string (password.ToArray());

            Console.WriteLine("Your generated password is: " + passwordFinal);
        }
        
        static void Randomizer(int count, char[] type, List<char> password) 
        {
            for (int x = 0; x < count; x++)
            {
                int index = random.Next(0, type.Length);
                char randomChar = type[index];
                password.Add(randomChar);
            }
        }

    }
}
