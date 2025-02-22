namespace EmployeeWage
{
    internal class Program
    {
        //these constant are for comparing the employee attendance
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 1;
        const int EMP_RATE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            //varaiables
            int empHrs = 0;
            int empWage = 0;

            Console.WriteLine("Welcome to Employee Wage Application");
            Console.WriteLine("Click 0 if Absent ,Click 1 if part time , Click 2 for full time");

            int empCheck = Convert.ToInt32(Console.ReadLine());
            switch(empCheck)
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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);

            Console.ReadLine();

        }
    }
}


