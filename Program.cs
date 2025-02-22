namespace EmployeeWage
{
    internal class Program
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int computEngine(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //computations
            while (totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numOfWorkingDays)//because working day is pre incremented
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
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            int totalEmpWage = computEngine("Dmart", 20, 2, 10);
            Console.ReadKey();
        }
    }
}