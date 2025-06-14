namespace _14OOP_DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notepad notepad = new Notepad(null);
            //notepad.SpellCheck();
            //notepad.Cut();
            //notepad.Copy();

            //Notepad notepad = new Notepad("gr");
            //notepad.SpellCheck();
            //notepad.Cut();
            //notepad.Copy();

            //Notepad notepad = new Notepad("sp");
            //notepad.SpellCheck();
            //notepad.Cut();
            //notepad.Copy();

            //SpellCheckerFactory grFactory = new SpellCheckerFactory();
            //ISpellcker checker =  grFactory.GetSomeSpellChecker("gr");

            //Notepad notepad = new Notepad(checker);
            //notepad.SpellCheck();

            HindiSpellChecker hindiSpellChecker = new HindiSpellChecker();
            Notepad notepad = new Notepad(hindiSpellChecker);
            notepad.SpellCheck();
            notepad.Paste();

            KlingonSpellChecker klingonSpellChecker = new KlingonSpellChecker();
            Notepad notepad1 = new Notepad(klingonSpellChecker);
            notepad1.SpellCheck();

        }
    }

    public class Notepad
    {
        SpellCheckerFactory _factory = new SpellCheckerFactory();
        ISpellcker _cheker = null;

        // Constructor Level Dependency Injection Pattern
        public Notepad(ISpellcker checker) 
        {

            if (checker == null)
            {
                _cheker = _factory.GetSomeSpellChecker("en");
            }
            else
            {
                _cheker = checker;
            }
        }

        //public Notepad(string lang)
        //{

        //    if(lang == null)
        //    {
        //        _cheker = _factory.GetSomeSpellChecker("en");
        //    }
        //    else
        //    {
        //        _cheker = _factory.GetSomeSpellChecker(lang);
        //    }
        //}
        public void Cut()
        {
            Console.WriteLine("Cutting text...");
        }
        public void Copy()
        {
            Console.WriteLine("Copying text...");
        }
        public void Paste()
        {
            Console.WriteLine("Pasting text...");
        }
        public void SpellCheck()
        {
            // Consider this as a Min Project in itself
            _cheker.DoSpellCheck();
        }
    }
    public class SpellCheckerFactory
    {
        public ISpellcker GetSomeSpellChecker(string lang)
        {
            ISpellcker _checker = null;
            switch(lang)
            {
                case "en":
                    _checker =  new EnglishSpellChecker();
                    break;
                case "gr":
                    _checker = new GermanSpellChecker();
                    break;
                case "sp":
                    _checker = new SpanishSpellChecker();
                    break;
                default:
                    _checker = new EnglishSpellChecker(); // Default to English if no match
                    break;
            }
            return _checker;
        }
    }
    public interface ISpellcker
    {
        void DoSpellCheck();
    }

    public class HindiSpellChecker : ISpellcker
    {
        public void DoSpellCheck()
        {
            // Consider this as a Min Project in itself
            Console.WriteLine("Checking spelling in Hindi...");
        }
    }

    public class KlingonSpellChecker : ISpellcker
    {
        public void DoSpellCheck()
        {
            // Consider this as a Min Project in itself
            Console.WriteLine("Checking spelling in Klingon language...");
        }
    }
    public class EnglishSpellChecker : ISpellcker
    {
        public void DoSpellCheck()
        {
            // Consider this as a Min Project in itself
            Console.WriteLine("Checking spelling in English...");
        }
    }

    public class GermanSpellChecker : ISpellcker
    {
        public void DoSpellCheck()
        {
            // Consider this as a Min Project in itself
            Console.WriteLine("Checking spelling in German...");
        }
    }

    public class SpanishSpellChecker : ISpellcker
    {
        public void DoSpellCheck()
        {
            // Consider this as a Min Project in itself
            Console.WriteLine("Checking spelling in Spanish...");
        }
    }
}
