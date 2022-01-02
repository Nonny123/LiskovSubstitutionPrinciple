using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Gbenga";
            accountingVP.LastName = "Olushola";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Employee();

            emp.FirstName = "Emeka";
            emp.LastName = "Obi";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            IManager ceo = new CEO();
            ceo.FirstName = "Bill";
            ceo.LastName = "Gate";
            ceo.CalculatePerHourRate(2);

            IManaged ceo2 = new Manager();

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");
            Console.WriteLine($"{ ceo.FirstName }'s salary is ${ ceo.Salary }/hour.");
            ceo.GeneratePerformanceReview();


            Console.ReadLine();
        }
    }
}
