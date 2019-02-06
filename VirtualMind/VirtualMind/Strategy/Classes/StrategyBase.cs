using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtMVC.Strategy.Models;

namespace VirtualMind.Strategy.Classes
{
    public abstract class StrategyBase
    {
        public abstract Currency fetchData();
    }
}
