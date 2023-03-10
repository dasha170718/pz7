using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7
{
    internal class Customer : IObserver
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is Store)
            {
                Store store = (Store)subject;
                List<string> discounts = store.GetDiscounts();
                Console.WriteLine("{0}, в магазине появились скидки: {1}", name, string.Join(", ", discounts));
            }
        }
    }
}
