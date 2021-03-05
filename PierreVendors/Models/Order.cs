namespace PierreVendors.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }
    public string Date { get; }

    public Order (string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}