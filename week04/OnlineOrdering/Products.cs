

public class Product
{
    private string _nameProduct;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _nameProduct = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string NameAndId()
    {
        return $"Product: {_nameProduct}, ID: {_productID}\n";
    }
}

