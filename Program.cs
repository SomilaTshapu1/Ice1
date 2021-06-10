using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Please Fill in the details!");
            Console.Write("Enter your Name");

            string Firstname;
            Firstname = Console.ReadLine();

            Console.Write("Enter your Surname");

            string Surname;
            Surname = Console.ReadLine();
           

            Console.Write("Enter your Student Number");
            int StudentNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Course Code");

            string Course;
            Course = Console.ReadLine();

            Console.Write("Enter your Cellphone Number");
            int Cellphone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hello," + Firstname + "" + Surname);
            Console.WriteLine("Your Contact Number is," + Cellphone );
            Console.WriteLine("Your Student Number is," + StudentNumber);
            Console.WriteLine("Your Course is," + Course);

        }
    }
}
