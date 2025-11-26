using ADV01.EX02V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01.EmployeeCustemComparer
{
    internal class EmployeeCustemComparer : IComparer<Employee>
    {
        public int Compare(Employee? emp01, Employee? emp02)
        {
            // Based On Name
            // if =>
            //1.emd01 == emp02 (null , same Object) => return 0
            //2.emp01 is null => return -1
            //3.emp02 is null => return 1
            //4.emp01.Name is  null => return -1
            //5.emp02.Name is null => return -1
            //6.emp01.Name > emp02.Name => return +1
            //7.emp01.Name < emp02.Name => return -1
            //8.emp01.Name == emp02.Name => return 0

            if (ReferenceEquals(emp01, emp02)) return 0;//1.emd01 == emp02 (null , same Object) => return 0
            if (emp01 is null) return -1;//2.emp01 is null => return -1
            if (emp02 is null) return 1;//3.emp02 is null => return 1
            // if Names is nulls  use string.Compare 
            return string.Compare()




        }
    }
}
