using ADV01.EX02V2;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.CustomEqualityComparer
{
    internal class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? emp01, Employee? emp02)
        {
            //cases to consider
            // emp01 == emp02 same object 
            // emp01 and emp02   one of them is null 
            // emp01 and emp02 both are not null have same reference 
            // emp01 and emp02 == same name
            // emp01 and emp02 != not the same name 
            if (ReferenceEquals(emp01, emp02))
            {
                return true;
            }
            if (emp01 is null || emp02 is null)
            {
                return false;
            }

            return string.Equals(emp01.Name, emp01.Name, StringComparison.OrdinalIgnoreCase);

            //if (emp01.Name.ToLower().Equals(emp02?.Name)) // not handel case sensitivity
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name is null ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name);       
            //return obj.Name?.GetHashCode() ?? 0; // handle null name case but not handel case sensitivity of name
        }
    }
}
