namespace _21MultiCastDeleagteDemo
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            AnnualFunction obj = new AnnualFunction();
            #region Using Single-cast deleagte syntax
            //MyDelegate del1 = new MyDelegate(obj.WelCome);
            //del1();
            //MyDelegate del2 = new MyDelegate(obj.Speech);
            //del2();
            //MyDelegate del3 = obj.CelebritySpeech; 
            //del3();
            #endregion

            #region Multi-cast deleagte 

            MyDelegate del = new MyDelegate(obj.WelCome);
            del += new MyDelegate(obj.Speech); // += coupling operator
            del += obj.CelebritySpeech; // += coupling operator
            del += obj.TalentShow; // += coupling operator
            del += obj.DinnerParty; // += coupling operator
            del += obj.GoodBye; // += coupling operator

            Console.WriteLine("Is it a closure ?");
            bool isClosure = Convert.ToBoolean(Console.ReadLine());
            if(isClosure)
            {
                del += obj.PackUp; // += coupling operator
            }
            else
            {
                del -= obj.PackUp; // -= de-coupling operator
            }

            del += obj.GoodNight; // += coupling operator

            del(); // Invoking the multicast - delegate

            #endregion
        }
    }

    public class AnnualFunction
    {
        public void WelCome()
        {
            Console.WriteLine("Wel-come everyone for our annual event function ....!!!!");
        }
        public void Speech()
        {
            Console.WriteLine("In-house Guest Speech : Blah blah blah....!!!!");
        }
        public void CelebritySpeech()
        {
            Console.WriteLine("Celebrity Guest Speech : Thank you everyone for having me tonight!! and blah blah blah....!!!!");
        }
        public void TalentShow()
        {
            Console.WriteLine("Next is  : Lets enjoy our performances | Dance | Sining | Drama!!!!");
        }
        public void DinnerParty()
        {
            Console.WriteLine("Next is  : Lets enjoy our dinner party!!!!");
        }
        public void GoodBye()
        {
            Console.WriteLine("Thank you everyone for enjoying and Good - night!!!!");
        }
        public void PackUp()
        {
            Console.WriteLine("Thank you everyone .. Lets Pack-up ");
        }
        public void GoodNight()
        {
            Console.WriteLine("Good - night!!!!");
        }
    }
}
