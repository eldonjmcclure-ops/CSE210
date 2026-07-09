class Order
{
    private double _shippingCost;
	private List<Product> _products;
    private Customer _customer;
    private double _totalPrice;

    public Order( List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

	public double GetShippingCost()
    {
        return _shippingCost;
    }
	public void SetShippingCost(double shippingCost)
    {
        _shippingCost = shippingCost;
    }
	public List<Product> GetProducts()
    {
        return _products;
    }
	public void SetProducts()
    {

    }
	public double CalculateTotalPrice()
    {
        foreach (Product product in _products)
        {
            int quantity = product.GetQuantity();
            double price = product.GetPricePerUnit();
            _totalPrice += quantity * price;
        }
        return Math.Round(_totalPrice + _shippingCost,2);
    }
    public void AssignShippingCost()
    {
        if (_customer.GetNationality() == "USA")
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }
	public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"ID: {product.GetProductId()}");
            Console.WriteLine($"{product.GetName()}");
            Console.WriteLine();
        }
        
    }
	public void DisplayShippingLabel()
    {
        Console.WriteLine("Recipient:");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetCustomerAddress());
    }

}