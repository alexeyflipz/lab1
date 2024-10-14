using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public decimal CalculateSalary()
        {
            decimal baseSalary;

            switch (Position.ToLower())
            {
                case "junior":
                    baseSalary = 30000;
                    break;
                case "middle":
                    baseSalary = 50000;
                    break;
                case "senior":
                    baseSalary = 70000;
                    break;
                case "lead":
                    baseSalary = 90000;
                    break;
                default:
                    baseSalary = 30000;
                    break;
            }

            return baseSalary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Спiвробiтник: {FirstName} {LastName}");
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Оклад: {CalculateSalary()} грн");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть iм'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введiть прiзвище: ");
            string lastName = Console.ReadLine();

            Employee employee = new Employee(firstName, lastName);

            Console.Write("Введiть посаду (Junior, Middle, Senior, Lead): ");
            employee.Position = Console.ReadLine();

            employee.DisplayEmployeeInfo();
        }
    }
}
