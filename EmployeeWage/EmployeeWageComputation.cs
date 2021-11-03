using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class EmployeeWageComputation
    {
        public const int IS_PRESENT = 1;
        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}
