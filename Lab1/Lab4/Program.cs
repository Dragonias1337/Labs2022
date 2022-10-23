namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод с консоли

            MyMatrix a = new MyMatrix(3, 3, -1, 1);
            MyMatrix b = new MyMatrix(3, 3, -1, 1);
            MyMatrix c = a + b;

            a.Show();
            b.Show();
            c.Show();

        }
    }
}