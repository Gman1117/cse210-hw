public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const decimal USA_SHIPPING_COST = 5.00m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35.00m;

    public Order()
    {
        _products = new List<Product>();
    }

    public Customer Customer 
    { 
        get { return _customer; } 
        set { _customer = value; } 
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        decimal shippingCost = _customer.IsInUsa() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}