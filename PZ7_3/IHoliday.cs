using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7_3
{
    internal interface IHoliday
    {
        void RegisterClient(IClient client);
        void RemoveClient(IClient client);
        void Notify();
    }
}
