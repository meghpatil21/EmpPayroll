using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    internal class EmpPresentAbsent
    {
        public static void EmployeeAttendanceCheck()
        {
            Random random = new Random();
            int empCheck=random.Next(0, 2);
            if(empCheck == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
