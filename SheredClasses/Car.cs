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


        public Car(string aModel,int aSpeed, string aDriver)
        {
            Model = aModel;
            Speed = aSpeed;
            Driver = aDriver;
        }

        public int CalculateSpeed(int skill, int speed)
        {
            int result = skill * speed;
            return result;
        }

    }
}
