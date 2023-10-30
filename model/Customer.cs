namespace menukort.model
{
    public class Customer
    {

        // Instance Fields

        private int _nr;
        private string _name;
        private string _tlf;

        // Properties

        public int Nr
        {
            get { return _nr; }
            set { _nr = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        /*
         * Constructor
         */
        public Customer()
        {
            _nr = 0;
            _name = "";
            _tlf = "";
        }
        public Customer(int nr, string navn, string tlf)
        {
            _nr = nr;
            _name = navn;
            _tlf = tlf;
        }

        public override string ToString()
        {
            return $"{{{nameof(Nr)}={Nr.ToString()}, {nameof(Name)}={Name}, {nameof(Tlf)}={Tlf}}}";
        }
    }
}
