using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmployeeWageComputation employee = new EmployeeWageComputation();
            employee.DailyEmployeeWage();
        }
    }
}
