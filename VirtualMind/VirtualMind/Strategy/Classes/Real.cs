using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtMVC.Strategy.Models;

namespace VirtualMind.Strategy.Classes
{
    public class Real : StrategyBase
    {
        public override Currency fetchData()
        {
            throw new NotImplementedException();
        }
    }
}