using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._3
{
    class User
    {
        public string Login { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now; 
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"Логiн: {Login}");
            Console.WriteLine($"Iм'я: {FirstName}");
            Console.WriteLine($"Прiзвище: {LastName}");
            Console.WriteLine($"Вiк: {Age}");
            Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть логiн:");
            string login = Console.ReadLine();

            Console.WriteLine("Введiть iм'я:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введiть прiзвище:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введiть вiк:");
            int age = int.Parse(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);

            user.PrintUserInfo();
        }
    }
}
