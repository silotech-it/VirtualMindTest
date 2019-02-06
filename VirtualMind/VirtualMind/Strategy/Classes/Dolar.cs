using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using VirtMVC.Strategy.Models;

namespace VirtualMind.Strategy.Classes
{
    public class Dolar : StrategyBase
    {
        public override Currency fetchData()
        {
            var siteAnswer = new WebClient().DownloadString("https://www.bancoprovincia.com.ar/Principal/Dolar");
            var rawData = siteAnswer.Split('"');
            return new Currency(Convert.ToString(rawData[1]), Convert.ToString(rawData[3]), Convert.ToString(rawData[5]));
        }
    }
}