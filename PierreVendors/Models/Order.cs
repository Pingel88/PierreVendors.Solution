namespace PierreVendors.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public int Price { get; }

    public Order (string title, string description, int price)
    {
      Title = title;
      Description = description;
      Price = price;
    }
  }
}