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


        static public int CalculateSpeed(Driver driver,int speed)
        {

            int result = driver.Skill * speed;
            return result;
        }

    }

}
