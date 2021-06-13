using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        #region Props
        private double basic;

        public double Basic
        {
            get { return basic; }
            set { basic = value; }
        }


        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }



        #endregion

        #region constructors
        public ConfirmEmployee(): base()
        {
            this.Basic = 5000.0;
            this.Designation = "default designation"; 
        }

        public ConfirmEmployee(double pbasic, string pdesignation, string pname, string paddress) : base(pname, paddress)
        {
            if (pbasic < 5000.0)
            {
                throw new PoorSalaryException("Basic < 5000");
            }
            this.Basic = pbasic;
            this.Designation = pdesignation;
        }

        #endregion

        #region methods
        public sealed override double CalculateSalary()
        {
            double hra, conv, pf;
            if (Basic >= 3000)
            {
                hra = 0.3 * Basic;
                conv = 0.3 * Basic;
                pf = 0.1 * Basic;
            }
            else if (Basic >= 2000)
            {
                hra = 0.2 * Basic;
                conv = 0.2 * Basic;
                pf = 0.1 * Basic;
            }
            else
            {
                hra = 0.1 * Basic;
                conv = 0.1 * Basic;
                pf = 0.1 * Basic;
            }
            double netSalary = Basic + hra + conv - pf;
            return netSalary; 
        }
        public override string ToString()
        {
            return String.Format($"{base.ToString()}Basic: {Basic}, Designation: {Designation}\n");
        }
        #endregion
    }
}
