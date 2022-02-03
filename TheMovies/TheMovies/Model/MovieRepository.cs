using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TheMovies.Model
{
    public class MovieRepository
    {
        public List<Movie> movies = new List<Movie>();
        public Movie movie;

    public MovieRepository()
    {
        InitializeRepository();
    }
    private void InitializeRepository()
    {
        try
        {


            using (StreamReader sr = new StreamReader("Ex41-TheMovies.CSV.csv"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] parts = line.Split(',');
                    this.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9]);

                    line = sr.ReadLine();
                }

            }
        }
        catch (IOException)
        {
            throw;
        }

    }
    public Movie Add(string Cinema, string City, string PlayDate, string PlayTime, string MovieTitle, string MovieGenre, string MovieDirector, string PremierDate, string BookingMail,string BookingPhone)
    {
        Movie result = null;

            if (!string.IsNullOrEmpty(Cinema) &&
                !string.IsNullOrEmpty(City) &&
                !string.IsNullOrEmpty(PlayDate) &&
                !string.IsNullOrEmpty(PlayTime) &&
                !string.IsNullOrEmpty(MovieTitle) &&
                !string.IsNullOrEmpty(MovieGenre) &&
                !string.IsNullOrEmpty(MovieDirector) &&
                !string.IsNullOrEmpty(PremierDate) &&
                !string.IsNullOrEmpty(BookingMail) &&
                !string.IsNullOrEmpty(BookingPhone))
            {
                result = new Movie()
                {
                    Cinema = Cinema,
                    City = City,
                    PlayDate = PlayDate,
                    PlayTime = PlayTime,
                    MovieTitle = MovieTitle,
                    MovieGenre = MovieGenre,
                    MovieDirector = MovieDirector,
                    PremierDate = PremierDate,
                    BookingMail = BookingMail,
                    BookingPhone = BookingPhone
                };

                movies.Add(result);
            }
            else
                throw (new ArgumentException("Not all arguments are valid"));

            return result;
    }
        public List<Movie> GetAll()
        {
            return movies;
        }
}

}