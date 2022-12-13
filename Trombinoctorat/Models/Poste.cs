namespace Trombinoctorat.Models
{
    public class Poste
    {
        private long _id;
        private string _intitule;
        private string _description;

        public Poste(long id, string intitule, string description)
        {
            _id = id;
            _intitule = intitule;
            _description = description;
        }

        public long Id { get => _id; set => _id = value; }
        public string Intitule { get => _intitule; set => _intitule = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
