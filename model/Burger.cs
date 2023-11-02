namespace menukort.model
{
    public class Burger
    {
        private int _nummer;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private bool _vegan;


        public int Nummer { get { return _nummer; } set { _nummer = value; } }

        public string Navn { get { return _navn; } set { _navn = value; } }

        public string Beskrivelse { get { return _beskrivelse; } set { _beskrivelse = value; } }

        public double Pris { get { return _pris; } set { _pris = value; } }

        public bool Vegan { get { return _vegan; } set { _vegan = value; } }


        // Constructer

        public Burger()
        {
            _nummer = 0;
            _navn = "";
            _beskrivelse = "";
            _pris = 0;
            _vegan = false;
        }

        public Burger(int nummer, string navn, string beskrivelse, double pris, bool vegan)
        {
            _nummer = nummer;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _vegan = vegan;
        }
        public override string ToString()
        {
            return $"{{{nameof(Nummer)}={Nummer.ToString()}, {nameof(Navn)}={Navn}, {nameof(Beskrivelse)}={Beskrivelse}, {nameof(Pris)}={Pris.ToString()}, {nameof(Vegan)}={Vegan.ToString()}}}";
        }
    }
}
