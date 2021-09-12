using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAPI
{
   public class employeeBase:Iemployee
    { //employeebase inhert from Interface//
        public  int employeeID { get; set; }
       public string employeeName { get; set; }
       virtual public decimal employeeSalary { get ;set ;  }
    }
}
