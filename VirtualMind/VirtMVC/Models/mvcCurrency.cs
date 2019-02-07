using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace VirtMVC.Models
{
    public class mvcCurrency
    {
        [DisplayName("Price to Buy")]
        public string Price2Buy { get; set; }

        [DisplayName("Price to Sell")]
        public string Price2Sell { get; set; }

        [DisplayName("Last Update")]
        public string LastUpdate { get; set; }

        public mvcCurrency(string price2Buy, string price2Sel, string lastUpdate)
        {
            this.Price2Buy = price2Buy;
            this.Price2Sell = price2Sel;
            this.LastUpdate = lastUpdate;
        }

        public mvcCurrency()
        {
            this.Price2Buy = string.Empty;
            this.Price2Sell = string.Empty;
            this.LastUpdate = string.Empty;
        }
    }
}