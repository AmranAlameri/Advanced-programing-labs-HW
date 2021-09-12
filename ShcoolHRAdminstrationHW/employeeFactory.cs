using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolHRAPI;

namespace ShcoolHRAdminstrationHW
{ public enum employeeType
    {//enum items//
        Teacher,
        Head_Of_Dept,
        Head_Master
    }
    public class Teacher : employeeBase
    {  //Function for adding the bounce for teacher//
        public override decimal employeeSalary
        {
            get
            {
                return (base.employeeSalary + (base.employeeSalary * .05m));
            }

        }
    }
    public class Head_Of_Dept : employeeBase
    {  //Function for adding the bounce for Head of department//
        public override decimal employeeSalary
        {
            get
            {
                return (base.employeeSalary + (base.employeeSalary * .08m));
            }

        }
    }
    public class Head_Master : employeeBase
    {   //Function for adding the bounce for Head Master//
        public override decimal employeeSalary
        {
            get
            {
                return (base.employeeSalary + (base.employeeSalary * .10m));
            }

        }
    }
   public static class employeeFactory
    {//Fanction for checking the enum items//
    public static Iemployee getEmployeeInformation(string employeeType,int employeeID,string employeeName, decimal employeeSalary)
        {
            Iemployee employee = null;
            switch(employeeType)
            {
                case "Teacher":
                    {
                        employee = new Teacher { employeeID = employeeID, employeeName = employeeName, employeeSalary = employeeSalary };
                        break;
                    }
                case "Head_Of_Dept":
                    {
                        employee = new Head_Of_Dept { employeeID = employeeID, employeeName = employeeName, employeeSalary = employeeSalary };
                        break;
                    }
                case "Head_Master":
                    {
                        employee = new Head_Master { employeeID = employeeID, employeeName = employeeName, employeeSalary = employeeSalary };
                        break;
                    }

            }
            return employee;
        }
    }
}
