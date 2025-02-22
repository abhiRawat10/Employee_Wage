namespace EmployeeWage
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //computations for 20 days
            for(int day=0;day < NUM_OF_WORKING_DAYS; day++)
            {
                Console.WriteLine("Welcome to Employee Wage Application");
                Console.WriteLine("Click 0 if Absent ,Click 1 if part time , Click 2 for full time");
                int empCheck = Convert.ToInt32(Console.ReadLine());

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;//for 1 day
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("Total Emp Wage for 20 days: " + totalEmpWage);
        }
    }
}
