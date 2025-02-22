namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //computations for 20 days
            for(int day=0;day < 20; day++)
            {
                Console.WriteLine("Welcome to Employee Wage Application");
                Console.WriteLine("Click 0 if Absent ,Click 1 if part time , Click 2 for full time");
                int empCheck = Convert.ToInt32(Console.ReadLine());

                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * 20;//for 1 day
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);
            }
            Console.WriteLine("Total Emp Wage for 20 days: " + totalEmpWage);
        }
    }
}
