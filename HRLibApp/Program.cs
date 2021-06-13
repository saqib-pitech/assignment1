using System;
using System.Collections.Generic;
using HRLib;

namespace HRLibApp
{
    class Program
    {
        private static List<Employee> db;//= new List<Employee>();
        static void DisplayAll()
        {
            for (int i = 0; i < db.Count; i++)
            {
                Console.WriteLine(db[i]);
            }
        }
        static bool DeleteEmployee(int pempno)
        {
            //db.Remove
            for (int i = 0; i < db.Count; i++)
            {
                if(db[i].Empno == pempno)
                {
                    db.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        static void DispEmployee(int pempno)
        {
            //db.Remove
            for (int i = 0; i < db.Count; i++)
            {
                if (db[i].Empno == pempno)
                {
                    Console.WriteLine(db[i]);
                    return;
                }
            }
            Console.WriteLine("No Employee Found");
        }
        static void InsertCEmployee()
        {
            Console.Write("Name: ");
            string lname = Console.ReadLine();
            Console.Write("Address: ");
            string laddress = Console.ReadLine();
            Console.Write("Designation: ");
            string ldesign = Console.ReadLine();
            Console.Write("Salary (>=5000): ");
            double lsal = double.Parse(Console.ReadLine());

            try
            {
                db.Add(new ConfirmEmployee(lsal, ldesign, lname, laddress));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void InsertTrainee()
        {
            Console.Write("Name: ");
            string lname = Console.ReadLine();
            Console.Write("Address: ");
            string laddress = Console.ReadLine();
            Console.Write("No Of Days: ");
            int ldays = int.Parse(Console.ReadLine());
            Console.Write("Rate: ");
            double lrate = double.Parse(Console.ReadLine());
            db.Add(new Trainee(ldays, lrate, lname, laddress));
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Display All Employees\n2. Insert Confirm Employee\n3. Insert Trainee\n4. Delete Employee\n5. Display Employee by No\n0. Exit");
        }
        static void Main(string[] args)
        {
            #region confirmEmployee class test

            //ConfirmEmployee emp = new ConfirmEmployee();
            //ConfirmEmployee emp1 = new ConfirmEmployee(5001.0, "Admin", "Ram", "Delhi");
            /*try
            {
                ConfirmEmployee emp = new ConfirmEmployee();
                ConfirmEmployee emp1 = new ConfirmEmployee(999, "Admin", "Ram", "Delhi");  // throws exception
                Console.WriteLine(emp);
                Console.WriteLine(emp1);
            }
            catch (PoorSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            //Console.WriteLine(emp);
            //Console.WriteLine(emp1);
            #endregion
            #region Trainee class test
            /*
                        Trainee trainee = new Trainee();
                        Trainee trainee1 = new Trainee(2, 500, "Michael", "US");

                        Console.WriteLine(trainee);
                        Console.WriteLine(trainee1);*/
            #endregion

            db = new List<Employee>();
            //db.Add(new ConfirmEmployee(6000, "Comedian", "Chris", "Miami"));
            //db.Add(new ConfirmEmployee(8000, "Actor", "Tom", "New York"));
            //db.Add(new Trainee(10, 10000, "Ben", "Gotham"));
            //DeleteEmployee(1);
            //DisplayAll();

            int ch;
            do
            {
                ShowMenu();
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        DisplayAll();
                        break;
                    case 2:
                        InsertCEmployee();
                        break;
                    case 3:
                        InsertTrainee();
                        break;
                    case 4:
                        Console.Write("Employee Number: ");
                        DeleteEmployee(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Deleted");
                        break;
                    case 5:
                        Console.Write("Employee Number: ");
                        DispEmployee(int.Parse(Console.ReadLine()));
                        break;
                    default:
                        break;
                }
            } while (ch != 0);
        }
    }
}
