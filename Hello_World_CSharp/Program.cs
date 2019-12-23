using System;

namespace Hello_World_CSharp
{
    class MainClass
    {
        static string username;
        static string password;

        public static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("-----------Your account was successfully created---------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username to Login");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Hello World!");
                }
                else
                {
                    Console.WriteLine("Login Failed. Your password was incorrect. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login Failed. Your username was incorrect. Restart Program");
            }
         }
    }
}
