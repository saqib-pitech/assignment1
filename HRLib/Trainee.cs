using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Employee
    {
        #region Props
        private int noOfDays;
        public int NoOfDays { get => noOfDays; set => noOfDays = value; }
        private double ratePerDay;
        public double RatePerDay { get => ratePerDay; set => ratePerDay = value; }
        #endregion

        #region constructors
        public Trainee() : base()
        {
            this.NoOfDays = 0;
            this.RatePerDay = 0.0;
        }

        public Trainee(int pnoOfDays, double pratePerDay, string pname, string paddress) : base(pname, paddress)
        {
            this.NoOfDays = pnoOfDays;
            this.RatePerDay = pratePerDay;
        }

        #endregion

        #region methods
        public sealed override double CalculateSalary()
        {
            double netSalary = NoOfDays * RatePerDay;
            return netSalary;
        }
        public override string ToString()
        {
            return String.Format($"{base.ToString()}No. of Days: {NoOfDays}, Rate/Day: {RatePerDay}\n");
        }
        #endregion

    }
}
