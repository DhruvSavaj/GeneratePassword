using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password Length:");
            string passLength = Console.ReadLine();
            GenratePassword(Convert.ToInt32(passLength));
            
            Console.WriteLine("\nDo you want to Generate a new password yes or no ?");
            
            Console.WriteLine("Yes: y");
            Console.WriteLine("No: n");

            string wantToContinue = Console.ReadLine();
            while (wantToContinue.Contains("y") || wantToContinue.Contains("Y"))
            {
                Console.WriteLine("Enter Password Length:");
                passLength = Console.ReadLine();
                GenratePassword(Convert.ToInt32(passLength));
                Console.WriteLine("\nDo you want to Generate a new password y or n ?");
                wantToContinue = Console.ReadLine();
            }

            Console.WriteLine("Good Bye..!!");
            Console.ReadLine();
        }

        public static void GenratePassword(int len)
        {
            string password = "";
            string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerCase = "abcdefghijklmnopqrstuvwxyz";
            string Digit = "1234567890";
            string SpecialChar = "~!@#$%^&*()_+|{}[]:;<>,./?";

            string AllChar = UpperCase + Digit + LowerCase + SpecialChar;
            Random rnd = new Random();

            for (int i = 0; i < len; i++)
            {
                double random = rnd.NextDouble();
                if (i == 0)
                {
                    password += UpperCase.ToCharArray()[(int)Math.Floor(random * UpperCase.Length)];
                }
                else
                {
                    password += AllChar.ToCharArray()[(int)Math.Floor(random * AllChar.Length)];
                }
            }

            Console.WriteLine("Password: " + password);
            //Console.ReadLine();
        }
    }
}
