using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Lab2
{
    abstract class Vehicle
    {
        private double xcord;
        private double ycord;
        private int price;
        private double speed;
        private int yearOfManufact;

        public double Xcord { get => xcord; set => xcord = value; }
        public double Ycord { get => ycord; set => ycord = value; }
        public int Price { get => price; set => price = value; }
        public double Speed { get => speed; set => speed = value; }
        public int YearOfManufact { get => yearOfManufact; set => yearOfManufact = value; }

        public abstract void ShowStats();


    }
    class Plane : Vehicle
    {
        private double height;
        private int passengers;

        public double Height { get => height; set => height = value; }
        public int Passengers { get => passengers; set => passengers = value; }

        public Plane(double xcord, double ycord, int price, double speed, int year, double height, int passengers)
        {
            Xcord = xcord;
            Ycord = ycord;
            Price = price;
            Speed = speed;
            YearOfManufact = year;
            Height = height;
            Passengers = passengers;
        }

        public override void ShowStats()
        {
            Console.WriteLine($"Plane coordinates are:{Xcord} {Ycord}");
            Console.WriteLine($"Plane price is {Price}");
            Console.WriteLine($"Plane height is {Height}");
            Console.WriteLine($"Plane speed is {Speed}");
            Console.WriteLine($"Plane year of manufacturing is {YearOfManufact}");
            Console.WriteLine($"Plane has {Passengers} passengers");
            Console.WriteLine();
        }


    }
    class Car : Vehicle
    {
        public Car(double xcord, double ycord, int price, double speed, int year)
        {
            Xcord = xcord;
            Ycord = ycord;
            Price = price;
            Speed = speed;
            YearOfManufact = year;
        }

        public override void ShowStats()
        {
            Console.WriteLine($"Car coordinates are:{Xcord} {Ycord}");
            Console.WriteLine($"Car price is {Price}");
            Console.WriteLine($"Car speed is {Speed}");
            Console.WriteLine($"Car year of manufacturing is {YearOfManufact}");
            Console.WriteLine();
        }
    }
    class Ship : Vehicle
    {
        private int passengers;
        private string homeport = "";

        public int Passengers { get => passengers; set => passengers = value; }
        public string Homeport { get => homeport; set => homeport = value; }

        public Ship(double xcord, double ycord, int price, double speed, int year, int passengers, string homeport)
        {
            Xcord = xcord;
            Ycord = ycord;
            Price = price;
            Speed = speed;
            YearOfManufact = year;
            Passengers = passengers;
            Homeport = homeport;
        }

        public override void ShowStats()
        {
            Console.WriteLine($"Ship coordinates are:{Xcord} {Ycord}");
            Console.WriteLine($"Ship price is {Price}");
            Console.WriteLine($"Ship speed is {Speed}");
            Console.WriteLine($"Ship year of manufacturing is {YearOfManufact}");
            Console.WriteLine($"Ship has {Passengers} passengers");
            Console.WriteLine($"Ship homeport is {Homeport}");
            Console.WriteLine();
        }
    }
}
