using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "snow";
            string password = "password";
            using (StreamWriter writer = new StreamWriter(@"D:\login.storage"))
            {
                writer.WriteLine(username);
                writer.WriteLine(password);
            }
            if (File.Exists(@"D:\login.storage"))
            {
                int counter = 0;
                string line;

                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\login.storage");
                while ((line = file.ReadLine()) != null)
                {
                    switch (counter)
                    {
                        case 0:
                            Console.WriteLine("Username: "+line);
                            break;
                        case 1:
                            Console.WriteLine("Password: "+line);
                            break;
                        default:
                            Console.WriteLine("not defined :"+line);
                            break;
                    }
                    counter++;
                }

                file.Close();
            }

            Console.Read();
        }
    }
}
