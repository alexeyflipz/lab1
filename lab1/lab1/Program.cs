using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;


        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();

            myAddress.Index = "04209";
            myAddress.Country = "Україна";
            myAddress.City = "Київ";
            myAddress.Street = "Хрещатик";
            myAddress.House = 23;
            myAddress.Apartment = 132;

            Console.WriteLine("Iндекс: " + myAddress.Index);
            Console.WriteLine("Країна: " + myAddress.Country);
            Console.WriteLine("Мiсто: " + myAddress.City);
            Console.WriteLine("Вулиця: " + myAddress.Street);
            Console.WriteLine("Будинок: " + myAddress.House);
            Console.WriteLine("Квартира: " + myAddress.Apartment);
        }
    }
}
