using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExemploInterfaceComparable.Entitites
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) { 

            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing erro: argument is not");
            }

            // variavel temporaria
            Employee other = obj as Employee;
            //Comparar os funcionarios Nome ou Salario
            return Salary.CompareTo(other.Salary);
        }
    }
}

