public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string StreetAddress 
    { 
        get { return _streetAddress; } 
        set { _streetAddress = value; } 
    }

    public string City 
    { 
        get { return _city; } 
        set { _city = value; } 
    }

    public string StateProvince 
    { 
        get { return _stateProvince; } 
        set { _stateProvince = value; } 
    }

    public string Country 
    { 
        get { return _country; } 
        set { _country = value; } 
    }

    public bool IsInUsa()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}
