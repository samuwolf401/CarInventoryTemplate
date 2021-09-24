using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInventory
{
    class Car
    {
        public int year, milage;
        public string make, colour;

         public Car(int _year, string _make, string _colour, int _milage)
         {
            year = _year;
            make = _make;
            colour = _colour;
            milage = _milage;

         }

    }
}
