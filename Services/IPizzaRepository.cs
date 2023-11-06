using menukort.model;

namespace menukort.Services
{
    public interface IPizzaRepository
    {
        List<Pizza> ListeAfPizza { get; set; }

        List<Pizza> HentAllePizza();
        Pizza HentPizza(int nummer);
        Pizza Slet(int nummer);
        Pizza Slet(Pizza Pizza);
        void Tilføj(Pizza Pizza);
    }
}