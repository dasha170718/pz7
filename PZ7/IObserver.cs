﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ7
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
