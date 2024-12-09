public class Address 
{
    private string street;
    private string city;
    private string state;
    private string zipCode;

    public string Street 
    { 
        get { return street; } 
        set { street = value; } 
    }

    public string City 
    { 
        get { return city; } 
        set { city = value; } 
    }

    public string State 
    { 
        get { return state; } 
        set { state = value; } 
    }

    public string ZipCode 
    { 
        get { return zipCode; } 
        set { zipCode = value; } 
    }

    public string GetFullAddress()
    {
        return $"{street}, {city}, {state} {zipCode}";
    }
}