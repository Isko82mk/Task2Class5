using System;
using System.Collections.Generic;
using System.Text;

namespace pom1
{
   public class print
    {
        public void printDetalas()
        {
            accept first = new accept();
            first.acceptdetals();

            Console.WriteLine($"Your name is {first.Name}");
        }

    }
}
