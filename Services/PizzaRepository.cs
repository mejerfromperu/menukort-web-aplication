using menukort.model;

namespace menukort.Services
{
    public class PizzaRepository
    {
        // instans felt 
        private List<Pizza> _liste;


        // evt property
        public List<Pizza> ListeAfPizza
        {
            get { return _liste; }
            set { _liste = value; }
        }


        // Konstruktør

        public PizzaRepository(bool mocData = false)
        {
            _liste = new List<Pizza>();


            if (mocData)
            {
                PopulateKundeRepository();
            }
        }

        private void PopulateKundeRepository()
        {
            _liste.Clear();
            _liste.Add(new Pizza(1, "Vesuvio", "varmt", 20, false, true, false));
            _liste.Add(new Pizza(2, "hawaii", "kold", 204, false, false, false));
            _liste.Add(new Pizza(3, "hawaii2", "koldyes", 2322, false, false, false));
            _liste.Add(new Pizza(4, "hawaii3", "koldno", 24404, false, false, false));
            _liste.Add(new Pizza(5, "hawaii4", "koldsd", 219204, false, false, false));
        }

        //Metoder

        public Pizza HentPizza(int nummer)
        {
            foreach (var pizza in _liste) 
            {
                if(pizza.Nummer == nummer)
                {
                    return pizza;
                }
            }
            return null;
        }

        public void Tilføj(Pizza Pizza)
        {
            _liste.Add(Pizza);
        }

        public List<Pizza> HentAllePizza()
        {
            return _liste;
        }



        public Pizza Slet(Pizza Pizza)
        {
            if (_liste.Contains(Pizza))
            {
                _liste.Remove(Pizza);
                return Pizza;
            }

            // findes ikke
            return null;
        }

    }
}
