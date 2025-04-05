class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;
    private double _productCost;

    public Product(string name, string ID, double price, int quantity)
    {
        _name = name;
        _productID = ID;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetProductCost()
    {
        _productCost = _pricePerUnit * _quantity;
        return _productCost;
    }
}