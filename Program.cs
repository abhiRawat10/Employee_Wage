using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject emp1 = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            emp1.computeEmpWage();
            Console.WriteLine(emp1.toString());
            Console.ReadKey();
        }
    }

    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //computaion
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Console.WriteLine("Welcome to Employee Wage Application");
                Console.WriteLine("Click 0 if Absent ,Click 1 if part time , Click 2 for full time");
                int empCheck = Convert.ToInt32(Console.ReadLine());
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + this.company + " is: " + totalEmpWage);

        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + totalEmpWage;
        }

    }
}
