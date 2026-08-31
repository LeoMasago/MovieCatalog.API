namespace MovieCatalog.API.DTOs
{
    public class MovieRequest
    {
        public string Titulo { get; set; } = string.Empty;
        public string Diretor { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
        public string Genero { get; set; } = string.Empty;
    }
}
