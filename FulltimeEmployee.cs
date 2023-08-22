using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox01
{
    class FulltimeEmployee
    {
        private decimal salary;
        public FulltimeEmployee(string name, string socialSecurityNumber, decimal salary)
            : base(name, socialSecurityNumber)
        {
            this.salary = salary;
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override decimal Paycheck()
        {
            decimal payAmount;
            payAmount = Salary / 52;
            return payAmount;
        }
        public override string ToString()
        {
            string str;
            str = string.Format("Fulltime Employee:\n") + base.ToString() + string.Format($"\nPay amount: {Paycheck():C}");
            return str;
        }
    }
}
