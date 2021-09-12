using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAPI
{
    public interface Iemployee
    { //Interface var setting//
        int employeeID { get; set; }
        string employeeName { get; set; }
        decimal employeeSalary { get; set; }
    }
}
