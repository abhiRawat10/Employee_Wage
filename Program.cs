namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //constants
            int IS_FULL_TIME = 1;
            Console.WriteLine("Enter 1 for present and 0 for absent");
            int EMP_RATE_PER_HOUR = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            int empCheck = Convert.ToInt32(Console.ReadLine());
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}
