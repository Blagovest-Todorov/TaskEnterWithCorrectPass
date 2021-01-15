using System;

namespace EnterCorrectPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            //first string this is username we read to generate pass                                                 
            char[] pass = new char[username.Length];
            int count = 0;

            for (int i = 0, j = username.Length - 1; i < username.Length; i++, j--)
            {
                pass[i] = username[j];  //We initalize array with correct reveresed password
            }

            string reversed = string.Join("", pass);   // Here we create the password to Log in! 

            while (true)
            {

                string correctPassword = Console.ReadLine();
                // Here we call User to enter correct pass that we compare 
                // with genereated revered pass from reversed array

                if (correctPassword == reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                count++;

                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");

            }
        }
    }
}
