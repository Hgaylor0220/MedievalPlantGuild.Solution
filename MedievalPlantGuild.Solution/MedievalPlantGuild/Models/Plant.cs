namespace MedievalPlantGuild.Models
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string CommonName { get; set; }
        public string LatinName { get; set; }
        public string Habitat { get; set; }
        public string Identification { get; set; }
        public string Uses { get; set; } 
        public bool Poisonous { get; set; }
    }
}
