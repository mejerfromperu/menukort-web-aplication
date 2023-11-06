namespace menukort.model
{
    public class Drikkevarer
    {
        private int _nummer;
        private string _navn;
        private string _størrelse;
        private double _pris;
        private bool _alkohol;

        public int Nummer { get { return _nummer; } set { _nummer = value; } }

        public string Navn { get { return _navn; } set { _navn = value; } }

        public string Størrelse { get { return _størrelse; } set { _størrelse = value; } }

        public double Pris { get { return _pris; } set { _pris = value; } }

        public bool Alkohol { get { return _alkohol; } set { _alkohol = value; } }

        // Constructer

        public Drikkevarer()
        {
            _nummer = 0;
            _navn = "";
            _størrelse = "";
            _pris = 0;
            _alkohol = false;
        }

        public Drikkevarer(int nummer, string navn, string størrelse, double pris, bool alkohol)
        {
            _nummer = nummer;
            _navn = navn;
            _størrelse = størrelse;
            _pris = pris;
            _alkohol = alkohol;
        }

        public override string ToString()
        {
            return $"{{{nameof(Nummer)}={Nummer.ToString()}, {nameof(Navn)}={Navn}, {nameof(Størrelse)}={Størrelse}, {nameof(Pris)}={Pris.ToString()}, {nameof(Alkohol)}={Alkohol.ToString()}}}";
        }
    }
}