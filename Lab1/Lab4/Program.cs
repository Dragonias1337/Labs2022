namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод с консоли

            //MyMatrix a = new MyMatrix(3, 3, -1, 1);
            //MyMatrix b = new MyMatrix(3, 3, -1, 1);
            //MyMatrix c = a + b;

            //a.Show();
            //b.Show();
            //c.Show();

            Car[] cars = new Car[] {
            new Car()
            {
                Name = "1488",
                ProductionYear = 1994,
                MaxSpeed = 100
            },
            new Car()
            {
                Name = "123",
                ProductionYear = 1999,
                MaxSpeed = 50
            },
            new Car()
            {
                Name = "22",
                ProductionYear = 2002,
                MaxSpeed = 60
            }
            };

            foreach (var o in cars) o.Show();
            Console.WriteLine();

            Array.Sort(cars, new CarComparerByName());
            foreach (var o in cars) o.Show();
            Console.WriteLine();

            Array.Sort(cars, new CarComparerByProdYear());
            foreach (var o in cars) o.Show();
            Console.WriteLine();

            Array.Sort(cars, new CarComparerByMaxSpeed());
            foreach (var o in cars) o.Show();
            Console.WriteLine();


        }
    }
}