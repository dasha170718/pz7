using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7_3
{
    internal class Holiday : IHoliday
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public Status status { get; set; }

        private List<IClient> clients = new List<IClient>();

        public Holiday(string name, DateTime date, Status status)
        {
            this.name = name;
            this.date = date;
            this.status = status;
        }

        public void RegisterClient(IClient client) =>
            clients.Add(client);

        public void RemoveClient(IClient client)
        {
            if (!clients.Contains(client))
                return;

            clients.Remove(client);
        }

        public void Notify()
        {
            foreach (IClient client in clients)
            {
                if (client.getStatus() >= status)
                {
                    client.Update(this, name);
                    continue;
                }

                client.Update(this, "Слыш, купи VIP");
            }
        }
    }
}
