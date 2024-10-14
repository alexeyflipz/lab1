using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{
    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

        public Converter(double usd, double eur, double pln)
        {
            usdRate = usd;
            eurRate = eur;
            plnRate = pln;
        }

        public double FromUAH(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / usdRate;
                case "eur":
                    return amount / eurRate;
                case "pln":
                    return amount / plnRate;
                default:
                    throw new ArgumentException("Невідома валюта.");
            }
        }

        public double ToUAH(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * usdRate;
                case "eur":
                    return amount * eurRate;
                case "pln":
                    return amount * plnRate;
                default:
                    throw new ArgumentException("Невідома валюта.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(usd: 41.2, eur: 45, pln: 10.5);

            Console.WriteLine("Виберiть тип операцiї:");
            Console.WriteLine("1. З гривнi в iноземну валюту");
            Console.WriteLine("2. З iноземної валюти в гривню");
            int operation = int.Parse(Console.ReadLine());

            Console.Write("Введiть валюту (usd, eur, pln): ");
            string currency = Console.ReadLine();

            if (operation == 1)
            {
                Console.Write("Введiть кiлькiсть гривень: ");
                double uahAmount = double.Parse(Console.ReadLine());
                double result = converter.FromUAH(uahAmount, currency);
                Console.WriteLine($"{uahAmount} грн = {result} {currency.ToUpper()}");
            }
            else if (operation == 2)
            {
                Console.Write("Введiть кiлькiсть валюти: ");
                double foreignAmount = double.Parse(Console.ReadLine());
                double result = converter.ToUAH(foreignAmount, currency);
                Console.WriteLine($"{foreignAmount} {currency.ToUpper()} = {result} грн");
            }
            else
            {
                Console.WriteLine("Невiрний вибiр операцiї.");
            }
        }
    }
}
