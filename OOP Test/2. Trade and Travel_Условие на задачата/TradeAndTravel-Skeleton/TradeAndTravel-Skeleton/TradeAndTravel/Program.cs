﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine(new ExtendedInteractionManager());
            engine.Start();
        }
    }
}
