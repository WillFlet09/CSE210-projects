class Order
{
    List<Product> _products;
    List<string> items = new List<string>(){
        "Green Apple", "Lasagna", "Cherry soda", "Blue cheese dressing", "Mustard", "Orange", "Root Beer", "Jalapeno poppers"
    };
    List<double> prices = new List<double>()
    {
        3.89, 14.98, 3.29, 4.50, 2.00, 3.97, 4.45, 5.79
    };
    List<string> IDs = new List<string>(){
        "4U8w", "E8S9", "99O2", "VD67", "Q18N", "NLZ4", "BG18", "FH3S"
    };

    Customer customer;
    private double _totalCost;

   public Order(Customer customer)
    {
        _products = new List<Product>();
        Address address = new Address("", "", "", "");
        this.customer = customer;
    }

    public double ShippingCost()
    {
        bool _isAmerican = customer.IsAmerican();
        double shippingCost = 0;
        if(_isAmerican == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public void GetOrder()
    {
        _totalCost = 0;
        Random rand = new Random();
        int cart = rand.Next(3,5);
        for(int i = 0; i < cart; i++)
        {
            GetProduct();
        }
        foreach(Product product in _products)
        {
            double price = product.GetProductCost();
            _totalCost = _totalCost + price;
        }
        double shippingCost = ShippingCost();
        _totalCost = _totalCost + shippingCost;
    }
    public void GetProduct()
    {
        Random rand = new Random();
        int product = rand.Next(0,items.Count());
        string item = items[product];
        double price = prices[product];
        string ID = IDs[product];
        int quantity = rand.Next(1, 5);
        Product product1 = new Product(item,ID,price,quantity);
        _products.Add(product1);
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach(Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} ({product.GetQuantity()}): {product.GetID()}");
        }
    }
    public string ShippingLabel()
    {
        string address = customer.GetAddress();
        return address;
    }

    public void DisplayLabels()
    {
        double shippingCost = ShippingCost();
        string name = customer.GetName();
        Console.WriteLine($"Shipping label: {name}, ({ShippingLabel()})");
        PackingLabel();
        Console.WriteLine($"Shipping Cost: {shippingCost}");
        Console.WriteLine($"Total Cost: {_totalCost}");
    }
}