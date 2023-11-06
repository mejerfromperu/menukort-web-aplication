using menukort.model;
using System.Text.Json;

namespace menukort.Services
{
    public class BurgerRepositoryJson : IBurgerRepository
    {
        private List<Burger> _liste;


        // evt property
        public List<Burger> ListeAfBurger
        {
            get { return _liste; }
            set { _liste = value; }
        }


        // Konstruktør

        public BurgerRepositoryJson()
        {
            _liste = ReadFromJson();

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
            WriteToJson();
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
                WriteToJson();
                return Burger;
            }

            // findes ikke
            return null;
        }

        public Burger Slet(int nummer)
        {

            int index = _liste.FindIndex(Burger => Burger.Nummer == nummer);
            if (index >= 0)
            {
                Burger slettetKunde = _liste[index];
                _liste.RemoveAt(index);
                WriteToJson();
                return slettetKunde;
            }
            else
            {
                return null;

            }
        }

        private const string FILENAME = "BurgerRepository.json";

        private List<Burger>? ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {
                StreamReader sr = File.OpenText(FILENAME);
                return JsonSerializer.Deserialize<List<Burger>>(sr.ReadToEnd());
            }
            else
            {
                return new List<Burger>();
            }
        }

        private void WriteToJson()
        {
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            Utf8JsonWriter writer = new Utf8JsonWriter(fs);
            JsonSerializer.Serialize(writer, _liste);
            fs.Close();
        }

    }
}
