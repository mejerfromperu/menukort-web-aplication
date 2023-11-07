using menukort.model;

namespace menukort.Services
{
    public class DrikkevarerRepository : IDrikkevarerRepository
    {
        // instans felt 
        private List<Drikkevarer> _liste;


        // evt property
        public List<Drikkevarer> ListeAfDrikkevarer
        {
            get { return _liste; }
            set { _liste = value; }
        }


        // Konstruktør

        public DrikkevarerRepository(bool mocData = false)
        {
            _liste = new List<Drikkevarer>();


            if (mocData)
            {
                PopulateKundeRepository();
            }
        }

        private void PopulateKundeRepository()
        {
            _liste.Clear();
            _liste.Add(new Drikkevarer(1, "Coca Cola", "1 Liter", 45, true));
            _liste.Add(new Drikkevarer(2, "Coca Cola Zero", "1 Liter", 45, true));
            _liste.Add(new Drikkevarer(3, "Sprite", "1 Liter", 23, true));
            _liste.Add(new Drikkevarer(4, "Faxe Kondi", "1 Liter", 45, true));
            _liste.Add(new Drikkevarer(5, "Fanta", "1 Liter", 45, true));
        }

        //Metoder

        public void Tilføj(Drikkevarer Drikkevarer)
        {
            _liste.Add(Drikkevarer);
        }

        public List<Drikkevarer> HentAlleDrikkevarer()
        {
            return _liste;
        }



        public Drikkevarer Slet(Drikkevarer Drikkevarer)
        {
            if (_liste.Contains(Drikkevarer))
            {
                _liste.Remove(Drikkevarer);
                return Drikkevarer;
            }

            // findes ikke
            return null;
        }
    }
}
