using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._41
{
    class Program
    {
        static void Main(string[] args)
        { }
            class Car
        {
            public string Make { set; get; }
            public int Year { set; get; }
            public string Location { set; get; }
        }

        //Step 2: Implement the IComparable interface
        public int CompareTo(object obj)
        {
            if (obj is Car)
            {
                Car c2 = (Car)obj;
                return Make.CompareTo(c2.Make);
            }
            else
                throw new ArgumentException("Object is not of type Car.");
        }


        //Step 3: Test Sorting by Make
        Car objCar = new Car();
        ArrayList carArray = new System.Collections.ArrayList();

        objCar.Make = "Audi";
objCar.Year = 2014;
objCar.Location = "Georgia";
carArray.Add(objCar);
objCar = null;
 
objCar = new Car();
        objCar.Make = "Mercedes";
objCar.Year = 2005;
objCar.Location = "Newyork";
carArray.Add(objCar);
objCar = null;
 
objCar = new Car();
        objCar.Make = "Toyota";
objCar.Year = 1999;
objCar.Location = "California";
carArray.Add(objCar);
objCar = null;
 
carArray.Sort();
        }
    }
}
