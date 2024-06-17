
namespace LagerStyringsSystem;

public class Warehouse
{
    public List<IProduct> products;

    public Warehouse(List<IProduct> products)
    {
        this.products = products;
    }

    public void AddItem(IProduct product)
    {
        products.Add(product);
    }

    public void RemoveItem(int index)
    {
        products.RemoveAt(index);
    }

    public  void ShowAllItemsInWarehouse()
    {
        ShowItemsBasedOnCategory();
    }

    private void ShowItemsBasedOnCategory()
    {
        Console.WriteLine("Items in Warehouse:");
        Console.WriteLine("Electronic Items:");
        foreach (var product in products)
        {
            if (product.GetType()==typeof(Electronic))
            {
                Console.Write($"ID: {products.IndexOf(product)} -> ");
                product.PrintInfo();
            }
        }

        Console.WriteLine("---------------------------------------------------");
        
        Console.WriteLine("Food Items:");
        foreach (var product in products)
        {
            if (product.GetType()==typeof(FoodItem))
            {
                Console.Write($"ID: {products.IndexOf(product)} -> ");
                product.PrintInfo();
            }
        }
        Console.WriteLine("---------------------------------------------------");
        
        Console.WriteLine("Cloth Items:");
        foreach (var product in products)
        {
            if (product.GetType()==typeof(Cloth))
            {
                Console.Write($"ID: {products.IndexOf(product)} -> ");
                product.PrintInfo();
            }
        }
        Console.WriteLine("---------------------------------------------------");
    }

}