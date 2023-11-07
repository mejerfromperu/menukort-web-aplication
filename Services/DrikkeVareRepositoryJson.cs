using menukort.model;
using System.Text.Json;

namespace menukort.Services
{
    public class DrikkeVareRepositoryJson : IDrikkevarerRepository
    {
        private List<Drikkevarer> _liste;


        // evt property
        public List<Drikkevarer> ListeAfDrikkevarer
        {
            get { return _liste; }
            set { _liste = value; }
        }


        // Konstruktør

        public DrikkeVareRepositoryJson()
        {
            _liste = ReadFromJson();

        }

        //private void PopulateKundeRepository()
        //{
        //    _liste.Clear();
        //    _liste.Add(new Drikkevarer(1, "Coca Cola", "1 Liter", 45, true));
        //    _liste.Add(new Drikkevarer(2, "Coca Cola Zero", "1 Liter", 45, true));
        //    _liste.Add(new Drikkevarer(3, "Sprite", "1 Liter", 23, true));
        //    _liste.Add(new Drikkevarer(4, "Faxe Kondi", "1 Liter", 45, true));
        //    _liste.5, "Fanta", "1 Liter", 45, true));
        //}

        //Metoder

        public void Tilføj(Drikkevarer Drikkevarer)
        {
            _liste.Add(Drikkevarer);
            WriteToJson();
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
                WriteToJson();
                return Drikkevarer;
            }

            // findes ikke
            return null;
        }

        private const string FILENAME = "DrikkeVareRepository.json";

        private List<Drikkevarer>? ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {
                StreamReader sr = File.OpenText(FILENAME);
                return JsonSerializer.Deserialize<List<Drikkevarer>>(sr.ReadToEnd());
            }
            else
            {
                return new List<Drikkevarer>();
            }
        }

        private void WriteToJson()
        {
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            Utf8JsonWriter writer = new Utf8JsonWriter(fs);
            JsonSerializer.Serialize(writer, _liste);
            fs.Close();
        }

        public Drikkevarer HentDrikkevarer(int nummer)
        {
            foreach (var drikkevarer in _liste)
            {
                if (drikkevarer.Nummer == nummer)
                {
                    return drikkevarer;
                }
            }
            return null;
        }
    }
}
