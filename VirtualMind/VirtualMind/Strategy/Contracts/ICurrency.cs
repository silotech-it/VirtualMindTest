namespace VirtMVC.Strategy.Contracts
{
    public interface ICurrency
    {
        string LastUpdate { get; set; }
        string Price2Buy { get; set; }
        string Price2Sell { get; set; }
    }
}