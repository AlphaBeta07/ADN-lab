using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Report 
    { 
        public void generateReport()
        {
            Console.WriteLine("Generating Report");
        }
    }

    class ReportSaver
    {
        public void saveReport()
        {
            Console.WriteLine("Saving Report");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            report.generateReport();

            ReportSaver saver = new ReportSaver();
            saver.saveReport();

            Discount student = new StudentDiscount();
            Console.WriteLine("Student Discount: " + student.GetDiscount() + "%");

            Discount senior = new SeniorDiscount();
            Console.WriteLine("Senior Discount: " + senior.GetDiscount() + "%");

            IFlyingBird bird = new Sparrow();
            bird.Fly();   // Works perfectly

            Ostrich ostrich = new Ostrich();
            Console.WriteLine("Ostrich cannot fly");

            Console.ReadLine();

        }
    }

}
