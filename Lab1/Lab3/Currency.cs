using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Currency
    {
        private double value;

        public double Value { get => value; set => this.value = value; }

    }

    class CurrencyUSD : Currency
    {
        private static double changeMultiplierRUB = 0.013476;
        private static double changeMultiplierEUR = 1.07;

        public static implicit operator CurrencyUSD(CurrencyEUR x)
        {
            return new CurrencyUSD { Value = x.Value * changeMultiplierEUR };
        }
        public static implicit operator CurrencyUSD(CurrencyRUB x)
        {
            return new CurrencyUSD { Value = x.Value * changeMultiplierRUB };
        }
    }

    class CurrencyEUR : Currency
    {
        private static double changeMultiplierRUB = 0.012568;
        private static double changeMultiplierUSD = 0.93406;

        public static implicit operator CurrencyEUR(CurrencyUSD x)
        {
            return new CurrencyEUR { Value = x.Value * changeMultiplierUSD };
        }
        public static implicit operator CurrencyEUR(CurrencyRUB x)
        {
            return new CurrencyEUR { Value = x.Value * changeMultiplierRUB };
        }
    }

    class CurrencyRUB : Currency
    {
        private static double changeMultiplierEUR = 79.57;
        private static double changeMultiplierUSD = 74.21;

        public static implicit operator CurrencyRUB(CurrencyUSD x)
        {
            return new CurrencyRUB { Value = x.Value * changeMultiplierUSD };
        }
        public static implicit operator CurrencyRUB(CurrencyEUR x)
        {
            return new CurrencyRUB { Value = x.Value * changeMultiplierEUR };
        }
    }




}
