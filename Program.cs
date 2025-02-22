namespace EmployeeWage
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            //Helper classes are in the same namespace's WageArray.cs file

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray(3);
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEngineWage();
        }
    }
}
