using System;
using SheredClasses;


namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            //Console.WriteLine("Hello World");
            Console.WriteLine("Select driver\n" +
                "1.Bob\n" +
                "2.Greg\n" +
                "3.Jill\n" +
                "4.Anne\n");
            string userDriverImput = Console.ReadLine();
            string userCarImput = Console.ReadLine();

            Car hiunday = new Car()
            {
                Model = "Hiunday",
                Speed = 160,
                Driver = userDriverImput
            };

            Driver Bob = new Driver()
            {
                Name = "Bob",
                Skill = 8
            };


         


            Console.WriteLine($"From the object hiundai { hiunday.Driver }");

           

            Console.ReadLine();
        }

      


    }
}

