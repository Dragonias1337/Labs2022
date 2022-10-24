namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMatrix a = new MyMatrix(5, 4, -1, 1);
            //a.Show();
            //Console.WriteLine();

            //a.ShowPartially(1, 3, 2, 2);
            //Console.WriteLine();

            //a.ChangeSize(7, 3);
            //a.Show();
            //Console.WriteLine();

            MyList<String> b = new MyList<String>();
            b.Append("123");
            b.Append("456");
            b.Append("789");
            Console.WriteLine(b.Count());

            foreach(var o in b) Console.WriteLine(o.ToString());

            Console.WriteLine(b[2]);

        }
    }
}