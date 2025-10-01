public class Address
{
    private string _address;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string address, string city, string stateOrProvince, string country)
    {
        _address = address;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "us" || _country.ToLower() == "united states")
        {
            return true;
        }

        return false;
    }

    public string Display()
    {
        return $"{_address}, {_city}, {_stateOrProvince}, {_country}";
    }
}