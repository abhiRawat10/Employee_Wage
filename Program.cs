namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Console.WriteLine("Enter 1 for present and 0 for absent");

            int empCheck = Convert.ToInt32(Console.ReadLine());
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
