using menukort.model;

namespace menukort.Services
{
    public interface IDrikkevarerRepository
    {
        List<Drikkevarer> ListeAfDrikkevarer { get; set; }

        List<Drikkevarer> HentAlleDrikkevarer();
        Drikkevarer Slet(Drikkevarer Drikkevarer);
        void Tilføj(Drikkevarer Drikkevarer);
    }
}