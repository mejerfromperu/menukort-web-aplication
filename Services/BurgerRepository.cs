using menukort.model;

namespace menukort.Services
{
    public class BurgerRepository
    {
        // instans felt 
        private List<Burger> _liste;


        // evt property
        public List<Burger> ListeAfBurger
        {
            get { return _liste; }
            set { _liste = value; }
        }


        // Konstruktør

        public BurgerRepository(bool mocData = false)
        {
            _liste = new List<Burger>();


            if (mocData)
            {
                PopulateKundeRepository();
            }
        }

        private void PopulateKundeRepository()
        {
            _liste.Clear();
            _liste.Add(new Burger(1, "Classic Hamburger", "100 g. oksekød, salat, tomat, agurk, burgerdressing", 50, false));
            _liste.Add(new Burger(2, "Classic Cheeseburger", "100 g. oksekød, cheddarost, salat, tomat, agurk, burgerdressing", 53, false));
            _liste.Add(new Burger(3, "Classic Baconburger", "100 g. oksekød, bacon, salat, tomat, agurk, burgerdressing", 53, false));
            _liste.Add(new Burger(4, "Classic Baconcheeseburger", "100 g. oksekød, cheddarost, bacon, salat, tomat, agurk, burgerdressing", 55, false));
            _liste.Add(new Burger(5, "Big Mamma Burger", "2 gange 100 g. oksekødbøffer, cheddarost, bacon, salat, tomat, agurk, mammas sovs", 65, false));
        }

        //Metoder

        public Burger HentBurger(int nummer)
        {
            foreach (var burger in _liste)
            {
                if (burger.Nummer == nummer)
                {
                    return burger;
                }
            }
            return null;
        }
        public void Tilføj(Burger Burger)
        {
            _liste.Add(Burger);
        }

        public List<Burger> HentAlleBurger()
        {
            return _liste;
        }



        public Burger Slet(Burger Burger)
        {
            if (_liste.Contains(Burger))
            {
                _liste.Remove(Burger);
                return Burger;
            }

            // findes ikke
            return null;
        }
    }
}
