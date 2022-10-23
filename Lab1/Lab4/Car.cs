using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Car
    {
        private string name;
        private int productionYear;
        private int maxSpeed;

        public string Name { get => name; set => name = value; }
        public int ProductionYear { get => productionYear; set => productionYear = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }


        public void Show()
        {
            Console.WriteLine($"Name: {name}, Prod. Year: {productionYear}, Max Speed: {maxSpeed}");        
        }
    }

    class CarComparerByName : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car? x, Car? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    class CarComparerByProdYear : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car? x, Car? y)
        {
            return x.ProductionYear - y.ProductionYear;
        }
    }
    class CarComparerByMaxSpeed : IComparer<Car>
    {
        int IComparer<Car>.Compare(Car? x, Car? y)
        {
            return x.MaxSpeed - y.MaxSpeed;
        }
    }

}
