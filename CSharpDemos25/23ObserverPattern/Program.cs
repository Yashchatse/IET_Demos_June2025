namespace _23ObserverPattern
{
    public delegate void NotifyDelegate(string message);
    internal class Program // News application // Observer
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // coupling multiple methods to the event :: Multi-cast event
            publisher.Notify += subscriber.MethodA;
            publisher.Notify += subscriber.MethodB;

            // Raise the event
            publisher.TriggerEvent();

            Console.WriteLine("-----------------------------------");
            // De-couple event :
            publisher.Notify -= subscriber.MethodB;

            publisher.TriggerEvent();
        }
    }
    public class Subscriber // Subscriber
    {
        public void MethodA(string message)
        {
            Console.WriteLine($"MethodA received : {message}");
        }
        public void MethodB(string message)
        {
            Console.WriteLine($"MethodB received : {message}");
        }
    }
    public class Publisher // Weather station, Amezon app server
    {
        public event NotifyDelegate Notify;

        public void TriggerEvent()
        {
            Notify?.Invoke("Event has been triggered....");

            //if (Notify != null)
            //{
            //    Notify.Invoke("Event has been triggered....");
            //}
        }
    }
}
