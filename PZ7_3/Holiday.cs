using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7_3
{
    internal class Holiday : IHoliday
    {
        //ABOBA
        public string Name { get; set; }
        public DateTime Date { get; set; }

        private List<IClient> clients = new List<IClient>();

        public Holiday(string name, DateTime date)
        {
            Name = name;
            Date = date;
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
                client.Update(this);
            }
        }
    }
}
