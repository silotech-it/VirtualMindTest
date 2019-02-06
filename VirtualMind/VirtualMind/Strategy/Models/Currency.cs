using VirtMVC.Strategy.Contracts;

namespace VirtMVC.Strategy.Models
{
    public class Currency : ICurrency
    {
        public string Price2Buy { get; set; }
        public string Price2Sell { get; set; }
        public string LastUpdate { get; set; }

        public Currency(string price2Buy, string price2Sel, string lastUpdate)
        {
            this.Price2Buy = price2Buy;
            this.Price2Sell = price2Sel;
            this.LastUpdate = lastUpdate;
        }

        public Currency()
        {
            this.Price2Buy  = string.Empty;
            this.Price2Sell = string.Empty;
            this.LastUpdate = string.Empty;
        }
    }
}