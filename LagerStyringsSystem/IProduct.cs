namespace LagerStyringsSystem;

public interface IProduct
{
    string Name { get; set; }
    double Price { get; set; }

    public void PrintInfo();
}