namespace MovieCatalog.API.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Diretor { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
    }
}
