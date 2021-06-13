using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
	public abstract class Employee
	{
		private static int count;
		#region fields & properties
		private int empno;

		public int Empno
		{
			get { return empno; }
			set { empno = value; }
		}


		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		#endregion
		#region constructor
		public Employee()
		{
			Name = "default name";
			Address = "default address";
			Empno = ++count;
		}
		public Employee(string pname, string paddress):this()
		{
			this.Name = pname;
			this.Address = paddress;
		}
		#endregion
		#region methods
		public abstract double CalculateSalary();
		public override string ToString()
		{
			return String.Format($"Emp No: {Empno}, Name: {Name}, Address: {Address}, Salary: {CalculateSalary()}\n");
		}
		#endregion

	}
}
