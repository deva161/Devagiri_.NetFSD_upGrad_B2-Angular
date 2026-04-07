using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IProductInfoDAL dal = new ProductInfoDAL();

        while (true)
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ProductInfo p = new ProductInfo();

                    int pid;
                    Console.Write("Enter Product ID: ");
                    while (!int.TryParse(Console.ReadLine(), out pid))
                        Console.Write("Invalid ID, try again: ");
                    p.ProductId = pid;

                    Console.Write("Enter Name: ");
                    p.ProductName = Console.ReadLine();

                    decimal price;
                    Console.Write("Enter Price: ");
                    while (!decimal.TryParse(Console.ReadLine(), out price))
                        Console.Write("Invalid price, try again: ");
                    p.ListPrice = price;

                    Console.Write("Enter Expiry Date (yyyy-mm-dd or empty): ");
                    string dateInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(dateInput))
                        p.ExpiryDate = null;
                    else if (DateTime.TryParse(dateInput, out DateTime dt))
                        p.ExpiryDate = dt;
                    else
                    {
                        Console.WriteLine("Invalid date! Setting NULL.");
                        p.ExpiryDate = null;
                    }

                    try
                    {
                        dal.InsertProduct(p);
                        Console.WriteLine("Product Added!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case 2:
                    var products = dal.GetAllProducts();
                    foreach (var item in products)
                    {
                        Console.WriteLine($"{item.ProductId} | {item.ProductName} | {item.ListPrice} | {item.ExpiryDate}");
                    }
                    break;

                case 3:
                    ProductInfo up = new ProductInfo();

                    Console.Write("Enter Product ID: ");
                    up.ProductId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter New Name: ");
                    up.ProductName = Console.ReadLine();

                    Console.Write("Enter New Price: ");
                    up.ListPrice = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Enter New Expiry Date: ");
                    string newDate = Console.ReadLine();
                    up.ExpiryDate = string.IsNullOrWhiteSpace(newDate) ? null : Convert.ToDateTime(newDate);

                    dal.UpdateProduct(up);
                    Console.WriteLine("Updated Successfully!");
                    break;

                case 4:
                    Console.Write("Enter Product ID to Delete: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    dal.DeleteProduct(id);
                    Console.WriteLine("Deleted Successfully!");
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}