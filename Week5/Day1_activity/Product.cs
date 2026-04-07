using System;

// Base Class
class Product
{
    public string Name { get; set; }

    // Encapsulation: private price field
    private double price;

    // Property with controlled access
    public double Price
    {
        get { return price; }
        protected set
        {
            if (value > 0)
                price = value;
        }
    }

    // Constructor
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    // Virtual method
    public virtual double CalculateDiscount()
    {
        return Price;
    }
}

// Derived Class: Electronics
class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price - (Price * 0.05); // 5% discount
    }
}

// Derived Class: Clothing
class Clothing : Product
{
    public Clothing(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price - (Price * 0.15); // 15% discount
    }
}
