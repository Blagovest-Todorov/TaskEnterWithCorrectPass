using System;

namespace EnterCorrectPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();                                                           
            char[] pass = new char[username.Length];

            for (int i = 0, j = username.Length - 1; i < username.Length; i++, j--)
            {                
                pass[i] = username[j]; 
            }
            
            string reversed = string.Join("", pass); 

            while (true)
            {
                string correctPassword = Console.ReadLine(); 
                
                if (correctPassword == reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");               
            }
        }
    }
}
