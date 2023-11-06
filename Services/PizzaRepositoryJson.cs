using menukort.model;
using System.Text.Json;

namespace menukort.Services
{
    public class PizzaRepositoryJson : IPizzaRepository
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

        public PizzaRepositoryJson()
        {
            _liste = ReadFromJson();

        }

        


        //Metoder

        public Pizza HentPizza(int nummer)
        {
            foreach (var pizza in _liste)
            {
                if (pizza.Nummer == nummer)
                {
                    return pizza;
                }
            }
            return null;
        }

        public void Tilføj(Pizza Pizza)
        {
            _liste.Add(Pizza);
            WriteToJson();
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
                WriteToJson() ;
                return Pizza;
            }

            // findes ikke
            return null;
        }

        public Pizza Slet(int nummer)
        {

            int index = _liste.FindIndex(pizza => pizza.Nummer == nummer);
            if (index >= 0) 
            {
                Pizza slettetKunde = _liste[index];
                _liste.RemoveAt(index);
                WriteToJson();
                return slettetKunde;
            }
            else
            {
                return null;

            }
        }


        // Json

        private const string FILENAME = "PizzaRepository.json";

        private List<Pizza>? ReadFromJson()
        {
            if (File.Exists(FILENAME))
            {
                StreamReader sr = File.OpenText(FILENAME);
                return JsonSerializer.Deserialize<List<Pizza>>(sr.ReadToEnd());
            }
            else
            {
                return new List<Pizza>();
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
