

namespace Inheritance
{
    class Worker : Human
    {
        string _job;
        Manager _superior;

        public Worker() { }
        public Worker(string name, string surname, string pesel) { Name = name; Surname = surname; Pesel = pesel; }
        public Worker(string name, string surname, string pesel, string street, int nr, string city, string postcode) { Name = name; Surname = surname; Pesel = pesel; Street = street; HouseNumber = nr; City = city; PostCode = postcode; }

        public Worker(string name, string surname, string pesel, string street, int nr, string city, string postcode, string job) { Name = name; Surname = surname; Pesel = pesel; Street = street; HouseNumber = nr; City = city; PostCode = postcode; _job = job;}

        public Worker(string name, string surname, string pesel, string street, int nr, string city, string postcode, string job, Manager superior) { Name = name; Surname = surname; Pesel = pesel; Street = street; HouseNumber = nr; City = city; PostCode = postcode; _job = job; _superior = superior; }
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        public Manager Superior
        {
            get { return _superior; }
            set { _superior = value; }
        
        }

    }
}
