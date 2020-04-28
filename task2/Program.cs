using System;
using SheredClasses;


namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName1 = Console.ReadLine();
            string driverName2 = Console.ReadLine();

            

            Car hiunday = new Car("Hiunday",160, driverName1);


            Driver Bob = new Driver("Bob", 8);

            Car speedCalc = new Car();


            int speedCalcFirstCar = speedCalc.CarSpeed(Bob,hiunday);


            Console.WriteLine(hiunday.Driver);

            Console.WriteLine(speedCalcFirstCar);























            //Console.WriteLine("Hello World");
            //Console.WriteLine("Select driver\n" +
            //    "1.Bob\n" +
            //    "2.Greg\n" +
            //    "3.Jill\n" +
            //    "4.Anne\n");
            //string userDriverImput = Console.ReadLine();
            //string userCarImput = Console.ReadLine();

            //Car hiunday = new Car()
            //{
            //    Model = "Hiunday",
            //    Speed = 160,
            //    //Driver = userDriverImput
            //};

            //Car Mazda = new Car()
            //{
            //    Model = "Mazda",
            //    Speed = 180,
            //    //Driver = userDriverImput
            //};


            //Driver Bob = new Driver()
            //{
            //    Name = "Bob",
            //    Skill = 8
            //};

            //Driver Greg = new Driver()
            //{
            //    Name = "Greg",
            //    Skill = 10
            //};

            //Car[] cars = new Car[] { hiunday, Mazda };
            //Driver[] drivers = new Driver[] { Bob, Greg };


            //Car speed = new Car();

            //speed.CalculateSpeed(Bob.Skill,hiunday.Speed);
            //Console.WriteLine($"From the object hiundai { hiunday.Driver }");
            Console.ReadLine();
        }

       


    }
}

