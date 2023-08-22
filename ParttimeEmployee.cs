using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox01
{
    class ParttimeEmployee
    {
        private decimal wage;
        private decimal hour;

        public ParttimeEmployee(string name, string socialSecurityNumber, decimal wage, decimal hour)
            : base(name, socialSecurityNumber)
        {
            this.wage = wage;
            this.hour = hour;
        }

        public decimal Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        public decimal Hour
        {
            get { return hour; }
            set { hour = value; } 
        }
        public override decimal Paycheck()
        {
            decimal payAmount;
            payAmount = Wage * Hour;
            return payAmount;
        }
        public override string ToString()
        {
            string str;
            str = string.Format("Parttime Employee:\n") + base.ToString() + string.Format($"\nPay amount: {Paycheck():C}");
            return str;
        }
    }
}
