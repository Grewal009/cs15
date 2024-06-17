namespace LagerStyringsSystem;

public class Menu
{
    public string MenuChoice { get; private set; }

    public void ShowMenu()
    {
        Console.WriteLine("\tMENU\n**********************");
        Console.WriteLine("press + to add item");
        Console.WriteLine("press - to remove item");
        Console.WriteLine("press S to show all items");
        Console.Write("press X to exit : ");
        MenuChoice = Console.ReadLine();
        Console.WriteLine();
    }

    public void Run(Warehouse warehouse)
    {
        while (true)
        {
            ShowMenu();
            switch (MenuChoice)
            {
                case "+":
                    AddItem(warehouse);
                    break;
                case "-":
                    RemoveItem(warehouse);
                    break;
                case "S":
                    warehouse.ShowAllItemsInWarehouse();
                    break;
                case "X":
                    return;
                default:
                    Console.WriteLine($"wrong input: {MenuChoice}");
                    Run(warehouse);
                    break;
            }
        }
    }

    public void AddItem(Warehouse warehouse)
    {
        int choice = AddItemMenu();
        switch (choice)
        {
            case 1:
                warehouse.AddItem(ItemDetails(choice));
                break;
            case 2:
                warehouse.AddItem(ItemDetails(choice));
                break;
            case 3:
                warehouse.AddItem(ItemDetails(choice));
                break;
            case 5:
                break;
            default:
                Console.WriteLine($"wrong input: {choice}");
                break;
        }
    }

    public int AddItemMenu()
    {
        Console.WriteLine("press 1 to add Electronic item");
        Console.WriteLine("press 2 to add Cloth item");
        Console.WriteLine("press 3 to add Food item");
        Console.Write("press 5 to exit : ");
        int addItemChoice = Convert.ToInt32(Console.ReadLine());
        return addItemChoice;
    }

    public IProduct ItemDetails(int choice)
    {
        string name;
        double price;
        string clothSize;
        string expiryDate;
        int warranty;

        Console.WriteLine("enter item name: ");
        name = Console.ReadLine();
        Console.WriteLine("enter price: ");
        price = Convert.ToDouble(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("enter guarantee in months: ");
            warranty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Item Added");
            return new Electronic(warranty, name, price);
        }
        else if (choice == 2)
        {
            Console.WriteLine("enter size of cloth: ");
            clothSize = Console.ReadLine();
            Console.WriteLine("Item Added");
            return new Cloth(clothSize, name, price);
        }
        else
        {
            Console.WriteLine("enter expiry date: ");
            expiryDate = Console.ReadLine();
            Console.WriteLine("Item Added");
            return new FoodItem(expiryDate, name, price);
        }
    }

    public void RemoveItem(Warehouse warehouse)
    {
        Console.Write("enter item id :");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index < 1 || index >= warehouse.products.Count)
        {
            Console.WriteLine("wrong input!!!");
        }
        else
        {
            warehouse.products.RemoveAt(index);
            Console.WriteLine($"item removed");
        }
    }
}