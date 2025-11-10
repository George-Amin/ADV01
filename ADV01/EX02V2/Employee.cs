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
            #region Unsave Casting -- Explicit casting
            //example of unsafe type casting
            //explicit casting
            /*
            Employee? emp = (Employee?)_obj;// type casting unsafe -- this way can throw Exception use as operator for safe type casting (V4)
            if (emp is not null)
            {
                Console.WriteLine("Employee Are Equal");
                return (this.Id == emp.Id) && (this.Name == emp.Name) && (this.Salary == emp.Salary);
            }
            else
            {
                return false;
            } 
            */
            #endregion

            #region Is Operator -- Safe Casting
            // example of safe type casting
            // using is operator to check type before casting and can cast inside (Optional with pattern matching) object to Employee
            /* return  
             

            True => if obj is Employee or Type derived (inherit) from Employee 
            ----> [then cast obj to Employee and compare the content Using (Pattern Matching)] Optional
                
            or
            False => if obj is not Employee 
             */

            //if (_obj is Employee /*(_emp) is pattern Matching => */ _emp)
            //{
            //    return (this.Id == _emp.Id) && (this.Name == _emp.Name) && (this.Salary == _emp.Salary);
            //}
            //else
            //{
            //    return false;
            //}



            #endregion


            #region As Operator 
            // example of safe type casting 

            Employee? emp = _obj as Employee; // safe type casting if fail return null
            if (emp is not null)
            {
                return (this.Id == emp.Id) && (this.Name == emp.Name) && (this.Salary == emp.Salary);
            }
            else
            {
                return false;
            }
            #endregion
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        #endregion
    }
}
