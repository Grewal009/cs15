using LagerStyringsSystem;

Warehouse warehouse = new Warehouse(new List<IProduct>());

Electronic tv = new Electronic(12, "TV", 12000);
Electronic pc = new Electronic(24, "PERSONAL COMPUTER", 9000);

Cloth shirt = new Cloth("M", "SHIRT", 550.99);
Cloth trouser = new Cloth("M", "TROUSER", 1999.99);

FoodItem bread = new FoodItem("20/06/2024", "BREAD", 39.99);
FoodItem eggs = new FoodItem("29/06/2024", "EGGS 6P", 24.99);

warehouse.AddItem(tv);
warehouse.AddItem(pc);
warehouse.AddItem(shirt);
warehouse.AddItem(trouser);
warehouse.AddItem(bread);
warehouse.AddItem(eggs);

//warehouse.ShowAllItemsInWarehouse();

Menu menu = new Menu();
menu.Run(warehouse);