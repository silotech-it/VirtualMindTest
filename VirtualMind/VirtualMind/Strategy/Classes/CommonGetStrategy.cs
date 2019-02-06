using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtMVC.Strategy.Models;

namespace VirtualMind.Strategy.Classes
{
    public class CommonGetStrategy
    {
        public StrategyBase Strategy { get; set; }

        public Currency Fetch() => Strategy.fetchData();
    }
}