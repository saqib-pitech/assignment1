using System;
using HRLib;

namespace HRLibApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region confirmEmployee class test

            ConfirmEmployee emp = new ConfirmEmployee();
            ConfirmEmployee emp1 = new ConfirmEmployee(999, "Admin", "Ram", "Delhi");  // throws exception
            /*try
            {
                ConfirmEmployee emp1 = new ConfirmEmployee(999, "Admin", "Ram", "Delhi");  // throws exception
                Console.WriteLine(emp1);
            }
            catch(PoorSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            Console.WriteLine(emp);
            Console.WriteLine(emp1);
            #endregion
            #region Trainee class test
            Trainee trainee = new Trainee();
            Trainee trainee1 = new Trainee(2, 500, "Michael", "US");

            Console.WriteLine(trainee);
            Console.WriteLine(trainee1);
            #endregion
        }
    }
}
