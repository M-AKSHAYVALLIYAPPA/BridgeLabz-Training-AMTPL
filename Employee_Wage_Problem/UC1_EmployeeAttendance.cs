using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class UC1_EmployeeAttendance
    {
        public void CheckAttendance()
        {

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 0)
                Console.WriteLine("Empleyee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
