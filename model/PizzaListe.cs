namespace menukort.model
{
    public class PizzaListe
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
         
        public PizzaListe()
        {
            _liste = new List<Pizza>();
        }


        
        //Metoder
         
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
