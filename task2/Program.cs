using System;
using SheredClasses;


namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Driver Bob = new Driver("Bob", 100);
            Driver Greg = new Driver("Greg", 120);
            Driver Jill = new Driver("Jill", 90);
            Driver Anne = new Driver("Anne", 80);

            Car Hyundai = new Car("Hyundai", 160, userNameImput) ;/// KAKO!!!!
            Car Mazda = new Car("Mazda", 180, );
            Car Ferrari = new Car("Ferrari", 360, );
            Car Porsche = new Car("Porsche", 320, );

            Console.WriteLine("Select first driver name \n" +
                "Bob\n" +
                "Greg\n" +
                "Jill\n" +
                "Anne\n");

            Console.WriteLine("Select second driver");
            string userNameImput1 = Console.ReadLine();

            Console.WriteLine("Select car \n" +
                "Hyundai\n" +
                "Mazda\n" +
                "Ferrari\n" +
                "Porsche\n");

            string userCarImput = Console.ReadLine();
            Console.WriteLine("Select second car");
            string userCarImput1 = Console.ReadLine();

            if (userNameImput=="Bob" && userCarImput== "Hyundai")
            {
                Hyundai.Driver = Bob.Name;
            }
         


          


            Console.WriteLine(Hyundai.CalculateSpeed(Hyundai.Speed, Bob.Skyll));
            ///Console.WriteLine($"I am comming from line 14 {firstCar.Driver}");

            Console.ReadLine();
        }

      


    }
}

