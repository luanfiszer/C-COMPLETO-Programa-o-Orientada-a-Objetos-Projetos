using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private double _salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            _salary = salary;
        }

        public double Salary
        {
            get { return _salary; }
            private set 
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Salário não pode ser negativo!");
                }
            }
        }

        public void IncreaseSalary(double percentage)
        {
            _salary = _salary * (percentage/100 + 1);
        }

        public override string ToString()
        {
            return $" {Id}, {Name}, {Salary}";
        }
    }
}
