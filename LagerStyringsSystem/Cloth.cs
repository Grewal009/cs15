namespace LagerStyringsSystem;

public class Cloth : IProduct
{
    private string _size;
    public string Name { get; set; }
    public double Price { get; set; }

    public Cloth(string size, string name, double price)
    {
        _size = size;
        Name = name;
        Price = price;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name:{Name}, Pris:{Price}, Size:{_size}");
    }

}