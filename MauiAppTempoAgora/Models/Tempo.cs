namespace MauiAppTempoAgora.Models
{
    public class Tempo
    {
        // Latitude e Longitude
        public double? lon { get; set; }
        public double? lat { get; set; }

        // Temperatura Mínima e Máxima
        public double? temp_min { get; set; }
        public double? temp_max { get; set; }

        // Visibilidade
        public int? visibility { get; set; }

        // Nascer e Por do Sol
        public string? sunrise { get; set; }
        public string? sunset { get; set; }

        // Descrições
        public string? main { get; set; }
        public string? description { get; set; }

        // Vento
        public double? speed { get; set; }
    }
}