using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        public static List<string> names = new List<string>();
        public static List<string> password = new List<string>();
        public static string userpassword;
        public static string username;
        public static string regname;
        public static string regpassword;
        static void Main(string[] args)
        {
            register();
            login();

        }
        public static void register()
        {
            Console.WriteLine("Enter your username: ");
            regname = Console.ReadLine();
            names.Add(regname);
            Console.WriteLine("ENter your password: ");
            regpassword = Console.ReadLine();
            password.Add(regpassword);

            if (!string.IsNullOrEmpty(regname) && !string.IsNullOrEmpty(regpassword))
            {
                Console.WriteLine("Register Complete");
            }
            else
            {
                Console.WriteLine("Enter proper credential");
            }

        }
        public static void login()
        {
            Console.WriteLine("Enter username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter useroasswird: ");
            userpassword = Console.ReadLine();

            if(names.Contains(username) && password[names.IndexOf(username)] == userpassword)
            {
                Console.WriteLine("Login succesfully");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}