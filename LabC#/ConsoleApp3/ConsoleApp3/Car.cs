using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car
    {

        public int Id;
        public static int Count;
        public string Name;
        public int Price;
        public int Speed;

        public Car(string name, int price, int speed)
        {
            Count++;
            Id = Count;
            Name = name;
            Price = price;
            Speed = speed;
        }


        // melumati cap eleyecek ekrana 
        public void GetInfoCar()
        {
            Console.WriteLine($"{Id} , {Name}, {Price} , {Speed}");
        }

        
    }
}
