using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7_3
{
    internal class Client : IClient
    {
        private string Name;
        private Status status;

        public Client(string name, Status status)
        {
            Name = name;
            this.status = status;
        }

        public Status getStatus() =>
            status;

        public void Update(IHoliday app, string notifycate)
        {
            Console.WriteLine(Name + " - " + notifycate);
        }
    }

    public enum Status{
        Amateur,
        Rookie,
        VIP
    }
}
