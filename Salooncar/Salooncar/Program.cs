using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salooncar
{
    class Program
    {
        static void Main(string[] args)
        {
            //in this class, instantiate car class
            var car = new Car("Red", "Large", "Toyota");
            //var car2 = new SaloonCar(4);

            Console.WriteLine("Car is " + car.color + " and is made by " + car.manufacturer);
            
        }
    }
    //create a car class. A CONSTRUCTOR IS CREATED INSIDE THE CLASS AND HAS SAME NAME AS THE CLASS
    public class Car
    {
        //create constructor
        public Car(string _color, string _size, string _manufacturer) {
            this.color = _color;
            this.size = _size;
            this.manufacturer = _manufacturer;
        }
            public string color { get; set; }
            public string size { get; set; }
            public string manufacturer { get; set; }
        
    }
    //create SaloonCar class    
    /*public class SaloonCar: Car
    {
        //create constructor 
        public SaloonCar(string _color, string)
        {

        }
   

    }*/

}
