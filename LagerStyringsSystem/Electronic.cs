namespace LagerStyringsSystem;

public class Electronic : IProduct
{
    private int _guaranteeInMonths;
    public string Name { get; set; }
    public double Price { get; set; }

    public Electronic(int guaranteeInMonths, string name, double price)
    {
        _guaranteeInMonths = guaranteeInMonths;
        Name = name;
        Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
            $"Name:{Name}, Pris:{Price}, Guarantee in months:{_guaranteeInMonths}");
    }

    
}