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
        static char randomLetter, randomSymbol, randomNum;
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

            for (int x = 0; x < letter; x++)
            {
                int index = random.Next(0, letters.Length);
                randomLetter = letters[index];
                password.Add(randomLetter);
            }

            Console.Write("How many symbols would you like? ");

            int symbol = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < symbol; x++)
            {
                int index = random.Next(0, symbols.Length);
                randomSymbol = symbols[index];
                password.Add(randomSymbol);
            }

            Console.Write("How many numbers would you like? ");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < num; x++)
            {
                int index = random.Next(0, numbers.Length);
                randomNum = numbers[index];
                password.Add(randomNum);
            }

            password = password.OrderBy(c => random.Next()).ToList();

            string passwordFinal = new string (password.ToArray());

            Console.WriteLine("Your password is: " + passwordFinal);
        }
        /*
        int Randomizer(int anon, char[] type, List<char> password) 
        {
            for (int x = 0; x < anon; x++)
            {
                int index = random.Next(0, type.Length);
                randomNum = type[index];
                password.Add(randomNum);
            }

            return password;
        }
        */

    }
}
