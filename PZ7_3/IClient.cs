using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7_3
{
    internal interface IClient
    {
        void Update(IHoliday app, string notifycate);

        Status getStatus();
    }
}
