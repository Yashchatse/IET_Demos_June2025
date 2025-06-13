namespace _11OOP_Abstract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Report pdf = new PDF();
            //pdf.Parse();
            //pdf.Save();
            //pdf.Validate();

            Console.WriteLine("Enter your report choice: 1. PDF, 2. DocX");
            int reportChoice = Convert.ToInt32(Console.ReadLine());
            ReportFactory factory = new ReportFactory();
            Report report = factory.GetSomeReport(reportChoice);
            report.GetReport();
        }
    }
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();

        public void GetReport()
        {
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report Generated Successfully!");
        }
    }
    public class ReportFactory
    {
        public Report GetSomeReport(int choice)
        {
            Report report = null;
            switch(choice)
            {
                case 1:
                    report = new PDF();
                    break;
                case 2:
                    report = new DocX();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            return report;
        }
    }
    public class PDF : Report
    {
        protected override void Parse()
        {
            //code here...
            Console.WriteLine("PDF Parsed..");
        }

        protected override void Validate()
        {
            //code here...
            Console.WriteLine("PDF Validated..");

        }
        protected override void Save()
        {
            //code here...
            Console.WriteLine("PDF Saved..");

        }
    }
    public class DocX : Report
    {
        protected override void Parse()
        {
            //code here...
            Console.WriteLine("DocX Parsed..");
        }

        protected override void Validate()
        {
            //code here...
            Console.WriteLine("DocX Validated..");

        }
        protected override void Save()
        {
            //code here...
            Console.WriteLine("DocX Saved..");

        }
    }
}
