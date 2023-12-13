namespace EntityFrameowrkChangTracker;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }


    public Product()
    {

    }
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
