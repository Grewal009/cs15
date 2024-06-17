using System.ComponentModel;

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

    public void ShowAllItemsInWarehouse()
    {
        
    }

    private void ShowItemsBasedOnCategory(  )
    {
        foreach (var product in products)
        {
            if (product.GetType()==typeof(Electronic))
            {
                product.PrintInfo();
            }
        }
        foreach (var product in products)
        {
            if (product.GetType()==typeof(FoodItem))
            {
                product.PrintInfo();
            }
        }
        foreach (var product in products)
        {
            if (product.GetType()==typeof(Cloth))
            {
                product.PrintInfo();
            }
        }
    }

}