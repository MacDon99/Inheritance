
namespace Inheritance
{
    abstract class Human
    {

        //guy
        string _name;
        string _surname;
        string _PESEL;
        //address
        string _street;
        int _houseNumber;
        string _city;
        string _postCode;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Pesel
        {
            get { return _PESEL; }
            set { _PESEL = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }
    }
}
