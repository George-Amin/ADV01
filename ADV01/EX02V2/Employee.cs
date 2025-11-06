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
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int _id, string? _name, decimal _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;

        }
        public override string ToString()
        {
            return $"Name is {Name} , Salary is {Salary} , Id is {Id} ";
        }

        #region Operator OverLoading
        public static bool operator ==(Employee _emp1, Employee _emp2)
        {
            //return (_emp1.Id == _emp2.Id) && (_emp1.Name == _emp2.Name) && (_emp1.Salary == _emp1.Salary);
            return _emp1.Equals(_emp2);
        }
        public static bool operator !=(Employee _emp1, Employee _emp2)
        {
            //return (_emp1.Id != _emp2.Id) || (_emp1.Name != _emp2.Name) || (_emp1.Salary != _emp1.Salary);
            return !_emp1.Equals(_emp2); // if the equal return true we want the opposite Use [!]
        }

        #endregion
        #region GetHashCode() -- Equals()
        public override bool Equals(object? _obj)
        {
            Employee? emp = (Employee?)_obj;
            if (emp is not null)
            {
                Console.WriteLine("Employee Are Equal");
                return (this.Id == emp.Id) && (this.Name == emp.Name) && (this.Salary == emp.Salary);
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        #endregion
    }
}
