using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox01
{
    abstract class Employee
    {
        private string name;
        private readonly string socialSecurityNumber;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Employee(string name, string socialSecurityNumber)
        {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
        }
        public abstract decimal Paycheck();

        public override string ToString()
        {
            string str;
            str = string.Format($"Employee Name: {name}" + $"\nSocial Security Number: {socialSecurityNumber}");
            return str;
        }
    }
}
