using System;
using System.Collections.Generic;
using System.Text;
using TheMovies.Model;

namespace TheMovies.ViewModel
{
    public class MovieViewModel
    {
        private Movie movie;

        public string Cinema { get; set; }
        public string City { get; set; }
        public string PlayDate { get; set; }
        public string PlayTime { get; set; }
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public string MovieDirector { get; set; }
        public string PremierDate { get; set; }
        public string BookingMail { get; set; }
        public string BookingPhone { get; set; }

        public MovieViewModel(Movie movie)
        {
            Cinema = movie.Cinema;
            City = movie.City;
            PlayDate = movie.PlayDate;
            PlayTime = movie.PlayTime;
            MovieTitle = movie.MovieTitle;
            MovieGenre = movie.MovieGenre;
            MovieDirector = movie.MovieDirector;
            PremierDate = movie.PremierDate;
            BookingMail = movie.BookingMail;
            BookingPhone = movie.BookingPhone;
        }

    }
}
