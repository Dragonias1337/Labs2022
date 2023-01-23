namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Все для 1 задания
            //MyMatrix a = new MyMatrix(5, 4, -1, 1);
            //a.Show();
            //Console.WriteLine();

            //a.ShowPartially(1, 3, 2, 2);
            //Console.WriteLine();

            //a.ChangeSize(7, 3);
            //a.Show();
            //Console.WriteLine();


            //Все для 2 задания
            //MyList<String> b = new MyList<String>();
            //b.Append("123");
            //b.Append("456");
            //b.Append("789");
            //Console.WriteLine(b.Count());

            //foreach(var o in b) Console.WriteLine(o.ToString());

            //Console.WriteLine(b[2]);

            //Все для 3 задания
            MyDictionary<int, string> mydic = new MyDictionary<int, string>(10);
            mydic.Add(1001, "Ivan");
            mydic.Add(1100, "Petr");
            mydic[1010] = "Egor";

            Console.WriteLine($"Всего в словаре {mydic.Lenght} элементов:\n");
            foreach (var item in mydic)
            {
                Console.WriteLine($"mydic[{item.Key}] = {item.Value}");
            }





        }
    }
}