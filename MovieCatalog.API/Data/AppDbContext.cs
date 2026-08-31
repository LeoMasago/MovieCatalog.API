using MovieCatalog.API.Models;

namespace MovieCatalog.API.Data
{
    public class AppDbContext
    {
        public List<Movie> Movies { get; set; }

        public AppDbContext()
        {
            Movies = new List<Movie>();

            Movie movie1 = new Movie();
            movie1.Id = 1;
            movie1.Titulo = "Scarface";
            movie1.Diretor = "Brian De Palma";
            movie1.AnoLancamento = 1983;
            movie1.Genero = "Crime";

            Movie movie2 = new Movie();
            movie2.Id = 2;
            movie2.Titulo = "Em Busca da Felicidade";
            movie2.Diretor = "Gabriele Muccino";
            movie2.AnoLancamento = 2006;
            movie2.Genero = "Drama";

            Movie movie3 = new Movie();
            movie3.Id = 3;
            movie3.Titulo = "Interestelar";
            movie3.Diretor = "Christopher Nolan";
            movie3.AnoLancamento = 2014;
            movie3.Genero = "Ficção Científica";

            Movie movie4 = new Movie();
            movie4.Id = 4;
            movie4.Titulo = "Diário de Uma Paixão";
            movie4.Diretor = "Nick Cassavetes";
            movie4.AnoLancamento = 2004;
            movie4.Genero = "Romance";

            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
            Movies.Add(movie4);
        }
    }
}
