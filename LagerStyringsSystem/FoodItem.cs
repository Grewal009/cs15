namespace LagerStyringsSystem;

public class FoodItem : IProduct
{
    private string _expiryDate;

    public string Name { get; set; }
    public double Price { get; set; }

    public FoodItem(string expiryDate, string name, double price)
    {
        _expiryDate = expiryDate;
        Name = name;
        Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
            $"Name:{Name}, Pris:{Price}, Expiry date:{_expiryDate}");
    }

    
}