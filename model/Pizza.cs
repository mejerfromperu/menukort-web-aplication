namespace menukort.model
{
    public class Pizza
    {
        private int _nummer;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private bool _vegan;
        private bool _deepPan;
        private bool _familie;

        public int Nummer {  get { return _nummer; } set {  _nummer = value; } }

        public string Navn { get { return _navn; } set { _navn = value; } }

        public string Beskrivelse { get {  return _beskrivelse; } set { _beskrivelse = value; } }

        public double Pris { get { return _pris; } set { _pris = value; } }

        public bool Vegan { get { return _vegan; } set { _vegan = value; } }

        public bool DeepPan { get { return _deepPan; } set { _deepPan = value; } }

        public bool FamilieSize { get { return _familie; } set { _familie = value; } }

        // Constructer

        public Pizza()
        {
            _nummer = 0;
            _navn = "";
            _beskrivelse = "";
            _pris = 0;
            _vegan = false;
            _deepPan = false;
            _familie = false;
        }

        public Pizza(int nummer, string navn, string beskrivelse, double pris, bool vegan, bool deepPan, bool familie)
        {
            _nummer=nummer;
            _navn=navn;
            _beskrivelse=beskrivelse;
            _pris=pris;
            _vegan=vegan;
            _deepPan=deepPan;
            _familie = familie;


        }

        public override string ToString()
        {
            return $"{{{nameof(Nummer)}={Nummer}, {nameof(Navn)}={Navn}, {nameof(Beskrivelse)}={Beskrivelse}, {nameof(Pris)}={Pris}, {nameof(Vegan)}={Vegan}, {nameof(DeepPan)}={DeepPan}, {nameof(FamilieSize)}={FamilieSize}}}";
        }
    }
}
