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

        public void Update(IHoliday app)
        {
            if (status == Status.Amateur)
                Console.WriteLine("Amateur");
            else if (status == Status.Rookie)
                Console.WriteLine("Rookie");
            else
                Console.WriteLine("VIP");
        }
    }

    public enum Status{
        Amateur,
        Rookie,
        VIP
    }
}
