using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.EX02V2
{
    internal class Employee

    {
        public  int  Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int _id , string? _name , decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;

        }
        public override string ToString()
        {
            return $"Name is {Name} , Salary is {Salary} , Id is {Id} ";
        }
    }
}
