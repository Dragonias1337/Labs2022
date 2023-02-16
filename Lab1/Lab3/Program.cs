namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarsCatalog c1 = new CarsCatalog();
            //for (int i = 0; i < c1.Soses.Count; i++)
            //{
            //    Console.WriteLine(c1[i]);
            //}

            CurrencyEUR wallet = new CurrencyEUR { Value = 1000 };
            Console.WriteLine($"В кошельке {wallet.Value} евро");
            CurrencyRUB wallet2 = wallet;
            Console.WriteLine($"Неявное преобразование: в кошельке {wallet2.Value} руб");
            CurrencyUSD wallet3 = (CurrencyUSD)wallet;
            Console.WriteLine($"Явное преобразование: в кошельке {wallet3.Value} $");

        }
    }
}