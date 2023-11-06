using menukort.model;

namespace menukort.Services
{
    public interface IBurgerRepository
    {
        List<Burger> ListeAfBurger { get; set; }

        List<Burger> HentAlleBurger();
        Burger HentBurger(int nummer);
        Burger Slet(int nummer);
        Burger Slet(Burger Burger);
        void Tilføj(Burger Burger);
    }
}