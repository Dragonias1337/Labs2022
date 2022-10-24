namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix a = new MyMatrix(5, 4, -1, 1);
            a.Show();
            Console.WriteLine();

            a.ShowPartially(1, 3, 2, 2);
            Console.WriteLine();

            a.ChangeSize(7, 3);
            a.Show();
            Console.WriteLine();



        }
    }
}