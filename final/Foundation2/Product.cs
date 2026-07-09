class Product
{
    private string _name;
	private int _productId;
	private double _pricePerUnit;
	private int _quantity;
	
	public Product(string name, int productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
	public string GetName()
    {
        return _name;
    }
	public void SetName(string name)
    {
        _name = name;
    }
	public int GetProductId()
    {
        return _productId;
    }
	public void SetProductId(int productId)
    {
        _productId = productId;
    }
	public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }
	public void SetPricePerUnit(double pricePerUnit)
    {
        _pricePerUnit = pricePerUnit;
    }
	public int GetQuantity()
    {
        return _quantity;
    }
	public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

}