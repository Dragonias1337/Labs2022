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
        
    }
    class Plane : Vehicle
    {
        private double height;
        private int passengers;

        public double Height { get => height; set => height = value; }
        public int Passengers { get => passengers; set => passengers = value; }

        public Plane (double xcord, double ycord, int price, double speed, int year, double height, int passengers)
        {
            Xcord = xcord;
            Ycord = ycord;
            Price = price;
            Speed = speed;
            YearOfManufact = year;
            Height = height;
            Passengers = passengers;
        }

        
    }
    class Car : Vehicle
    {
       

        public Car (double xcord, double ycord, int price, double speed, int year)
        {
            Xcord = xcord;
            Ycord = ycord;
            Price = price;
            Speed = speed;
            YearOfManufact = year;
        }
    }
    class Ship : Vehicle
    {
        private int passengers;
        private string homeport;

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
    }
}
