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

            Console.WriteLine("Enter your report choice: 1. PDF, 2. DocX 3. JSON, 4. XML");
            int reportChoice = Convert.ToInt32(Console.ReadLine());
            ReportFactory factory = new ReportFactory();
            Report report = factory.GetSomeReport(reportChoice);
            report.GenerateReport();
        }
    }
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();

        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
            Console.WriteLine("Report Generated Successfully!");
        }
    }
    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
            Console.WriteLine("Special Report Generated Successfully!");
        }
    }
    public class ReportFactory
    {
        public Report GetSomeReport(int choice)
        {
            Report report = null;
            switch (choice)
            {
                case 1:
                    report = new PDF();
                    break;
                case 2:
                    report = new DocX();
                    break;
                case 3:
                    report = new JSONDoc();
                    break;
                case 4:
                    report = new XML();
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

    public class JSONDoc : SpecialReport
    {
        protected override void Parse()
        {
            //code here...
            Console.WriteLine("JSONDoc Saved..");
        }

        protected override void Save()
        {
            //code here...
            Console.WriteLine("JSONDoc Saved..");
        }

        protected override void Validate()
        {
            //code here...
            Console.WriteLine("JSONDoc Valided..");
        }

        protected override void ReValidate()
        {
            //code here...
            Console.WriteLine("JSONDoc Re-Validated..");
        }
    }
    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            //code here...
            Console.WriteLine("XML Saved..");
        }

        protected override void Save()
        {
            //code here...
            Console.WriteLine("XML Saved..");
        }

        protected override void Validate()
        {
            //code here...
            Console.WriteLine("XML Valided..");
        }

        protected override void ReValidate()
        {
            //code here...
            Console.WriteLine("XML Re-Validated..");
        }
    }
}
