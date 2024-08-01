namespace HandsOnModels.Models
{
    public class MovieRepository
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie(){MovieId=1, Title="Inception", Actor="Leonardo DiCaprio", Lang="English", Director="Christopher Nolan"},
            new Movie(){MovieId=2, Title="The Dark Knight", Actor="Christian Bale", Lang="English", Director="Christopher Nolan"},
            new Movie(){MovieId=3, Title="Interstellar", Actor="Matthew McConaughey", Lang="English", Director="Christopher Nolan"},
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByName(string title)
        {
            return movies.SingleOrDefault(p => p.Title == title);
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
    }
}
