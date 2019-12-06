

namespace Inheritance
{
    class Client : Human
    {
        string _companyName;
        string _nip;
        string _street;
        int _houseNumber;
        string _city;
        string _postCode;


        public Client() { }
        public Client(string name, string surname, string pesel) { Name = name; Surname = surname; Pesel = pesel; }
        public Client(string name, string surname, string pesel, string street, int nr, string city, string postcode) { Name = name; Surname = surname; Pesel = pesel; Street = street; HouseNumber = nr; City = city; PostCode = postcode; }
        public Client(string companyName, string nip,string c_street, int c_housenumber, string c_city, string c_postcode ) { _companyName = companyName; _nip = nip;_street = c_street;_houseNumber = c_housenumber; _city = c_city; _postCode = c_postcode; }

        public string C_Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int C_HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }
        public string C_City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string C_PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

    }
}
