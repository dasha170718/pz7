using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7
{
    internal class Store : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<string> discounts = new List<string>();

        public void AddDiscount(string discount)
        {
            discounts.Add(discount);
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public List<string> GetDiscounts()
        {
            return discounts;
        }
    }
}
