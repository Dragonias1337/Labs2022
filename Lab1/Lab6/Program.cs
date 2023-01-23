using System;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Net;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Lab6
{
    struct Weather
    {
        private string country;
        private string name;
        private double temp;
        private string description;

        public string Country { get => country; set => country = value; }
        public string Name { get => name; set => name = value; }
        public double Temp { get => temp; set => temp = value; }
        public string Description { get => description; set => description = value; }

        public void Show()
        {
            Console.WriteLine($"{Country} {Name} {Description} {Temp}");
        }

    }

    internal class Program
    {
        static string getString(string ob, string key)
        {
            int Num = ob.IndexOf(key);
            if (Num == -1) return "";
            int Num2 = Num + key.Length + 3;
            int Num3 = ob.IndexOf('\"', Num2);
            return ob.Substring(Num2, Num3 - Num2);
        }
        static double getDouble(string ob, string key)
        {
            int Num = ob.IndexOf(key);
            if (Num == -1) return 0.0;
            int Num2 = Num + key.Length + 2;
            char[] buf = { ',', '}' };
            int Num3 = ob.IndexOfAny(buf, Num2);
            double rez;
            double.TryParse(ob.Substring(Num2, Num3 - Num2),
                             NumberStyles.Any,
                             CultureInfo.InvariantCulture,
                             out rez);
            return rez;
        }


        static async Task Main(string[] args)
        {
            const string APPID = "325d5a35f34ba6e1e4522d878093cbb6";
            Random random = new Random();
            var Data = new List<Weather>();
            for (int counter = 0; counter < 50;)
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?lat="
                           + (random.NextDouble() * 180 - 90)
                           + "&lon=" + (random.NextDouble() * 360 - 180)
                           + APPID;

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                httpRequest.Accept = "application/json";

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    string country = getString(result, "country");
                    string name = getString(result, "name");

                    if (country == "" || name == "") continue;

                    string description = getString(result, "description");
                    double temp = getDouble(result, "temp");
                    Weather weather = new Weather();
                    weather.Country = country;
                    weather.Name = name;
                    weather.Description = description;
                    weather.Temp = temp - 273;
                    weather.Show();
                    Data.Add(weather);
                    counter++;
                }
            }

            //  Ищем максимальную температуру 
            var max = Data.Max(M => M.Temp);
            Console.WriteLine("\nМаксимальная температура: " + max);
            var High = from M in Data
                       where M.Temp == max
                       select M;
            foreach (var M in High)
            {
                Console.WriteLine(M.Country + " " + M.Name);
            }

            //  Ищем минимальную температуру
            var min = Data.Min(m => m.Temp);
            Console.WriteLine("\nМинимальная температура: " + min);
            var Low = from m in Data
                      where m.Temp == min
                      select m;
            foreach (var m in Low)
            {
                Console.WriteLine(m.Country + " " + m.Name);
            }

            //  Вычисляем количество уникальных стран
            var nameNotEq = Data.DistinctBy(x => x.Name);
            int count = nameNotEq.Count();
            Console.WriteLine("\nКоличество уникальных стран: " + count);

            //  Вычисляем среднюю температуру
            var average = Data.Average(x => x.Temp);
            Console.WriteLine("\nСредняя температура: " + average);

            //  Проверяем наличие элемента с облачностью clear sky
            bool flag = false;
            foreach (var x in nameNotEq)
                if (x.Description == "clear sky") flag = true;

            if (flag == true)
            {
                var first = Data.First(x => x.Description == "clear sky");
                Console.WriteLine("\nПервый элемент с облачностью clear sky: ");
                first.Show();
            }
            else
            {
                Console.WriteLine("\nЭлемент с облачностью clear sky отсутствует ");
            }          
        }
    }
}