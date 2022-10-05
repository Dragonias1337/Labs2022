namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarsCatalog c1 = new CarsCatalog();
            for (int i = 0; i < c1.Soses.Count; i++)
            {
                Console.WriteLine(c1[i]);
            }
        }
    }
}