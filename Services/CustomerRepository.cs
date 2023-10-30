using menukort.model;
using System.Text;
using System.Xml.Linq;

namespace menukort.Services
{
    public class CustomerRepository
    {
        List<Customer> _list;

        public List<Customer> ListeAfKunder
        {
            get { return _list; }
            set { _list = value; }
        }

        // konstruktør
        public CustomerRepository(bool mocData = false)
        {
            _list = new List<Customer>();


            if (mocData)
            {
                PopulateKundeRepository();
            }
        }

        private void PopulateKundeRepository()
        {
            _list.Clear();
            _list.Add(new Customer(1, "Chris", "11211211"));
            _list.Add(new Customer(2, "Peter", "22222222"));
            _list.Add(new Customer(3, "Jens", "33333333"));
            _list.Add(new Customer(4, "Tubercoluse", "44444444"));
            _list.Add(new Customer(5, "Missecat", "55555555"));
        }



        // metoder

        public Customer Tilføj(Customer customer)
        {
            _list.Add(customer);

            return customer;
        }

        public void RemoveObject(List<Customer> list, Customer customer)
        {
            list.Remove(customer);
        }



        public Customer HentKundeUdFraTlf(string tlf)
        {
            Customer resKunde = null;

            foreach (Customer k in _list)
            {
                if (k.Tlf == tlf)
                {
                    return k;
                }
            }

            return resKunde;
        }


    }
}
