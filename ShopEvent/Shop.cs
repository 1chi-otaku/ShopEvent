using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopEvent
{

    public interface IObserver
    {
        void Update(IPublisher subject);

    }
    public interface IPublisher
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

    public class Shop : IPublisher
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Notifying observes...");
            foreach (var subscribers in observers)
            {
                subscribers.Update(this);
            }
        }

        public void PublishNewIPhone()
        {
            Console.WriteLine("\nSubject: I've just published a new IPHONE 34.");
            this.Notify();
        }
    }

    class IphoneSubscriber : IObserver
    {
        public void Update(IPublisher subject)
        {
            Console.WriteLine("IphoneSubribers: Hooray! New Iphone just hot published!");
        }
    }

    class AndroidSubscriber : IObserver
    {
        public void Update(IPublisher subject)
        {
            Console.WriteLine("AndroidSubscriber: This is just spam...");
        }
    }
}
