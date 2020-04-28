using System;
using System.Collections.Generic;
using System.Text;

namespace SheredClasses
{
  public  class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }



        public Car(string aModel, int aSpeed, string aDriver)
        {
            Model = aModel;
            Speed = aSpeed;
            Driver = aDriver;
        }

        public Car()
        {
        }

        public int CarSpeed(Driver driver, Car car)
        {
           int sum= driver.Skill * car.Speed;
           return sum;
        }

        public void RaceCars(Car car1, Car car2) {

            if (car1.CarSpeed() > car2.CarSpeed())
            {

            }
        }
    }

}
