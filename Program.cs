using System;
using System.Collections

namespace dropbox01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(new FulltimeEmployee("Alice", "111-11-1234", 87999.00m));
            allEmployees.Add(new FulltimeEmployee("Bob", "111-11-2345", 81234.00m));
            allEmployees.Add(new ParttimeEmployee("Chuck", "111-11-3456", 22.00m, 35.6m));
            allEmployees.Add(new ParttimeEmployee("Dan", "111-11-5678", 22.50m, 40m));
            allEmployees.Add(new ParttimeEmployee("Frank", "111-11-6789", 12.50m, 38.4m));

            foreach(Employee emp in allEmployees)
            {
                Console.WriteLine(emp);
            }
            foreach(Employee emp in allEmployees)
            {
                if(emp is ParttimeEmployee)
                {
                    ParttimeEmployee pte = (ParttimeEmployee)emp;
                    pte.Wage = 1.10m * pte.Wage;
                    Console.WriteLine($"{pte.Name}'s new wage will be {pte.Wage:C");
                }
            }
            Console.ReadKey();
        }
    }
}
