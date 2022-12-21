using System;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Net;
using System.ComponentModel.DataAnnotations;

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
    }

    internal class Program
    {        


        static async Task Main(string[] args)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using var client = new HttpClient(clientHandler);

            var content = await client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={0}&appid=325d5a35f34ba6e1e4522d878093cbb6");
            Console.WriteLine(content);
        }
    }
}