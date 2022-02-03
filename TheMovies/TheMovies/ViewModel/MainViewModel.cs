using System;
using System.Collections.Generic;
using System.Text;
using TheMovies.Model;

namespace TheMovies.ViewModel
{
    public class MainViewModel
    {
        private MovieRepository movieRepo = new MovieRepository();
        public List<MovieViewModel> LosMovies { get; set; }

        public MainViewModel()
        {
            LosMovies = new List<MovieViewModel>();

            foreach(Movie movie in movieRepo.GetAll())
            {
                MovieViewModel movieViewModel = new MovieViewModel(movie);
                LosMovies.Add(movieViewModel);
            }
        }

    }
}
