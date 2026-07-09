class Customer
{
    private string _name;
	private Address _address;
	
	public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
	public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
	public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
	public string GetNationality()
    {
        return _address.GetCountry();
    }
    public string GetCustomerAddress()
    {
        return _address.GetFullAddress();
    }
}