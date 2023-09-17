using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine_01
{
    internal class Director :Person
    {
        private static readonly float _serialVersionUID = 9529643602740204205L;
        private List<Movie> _directedMovies;

        public Director(string name, string firstname,
            DateTime birthDate) : base(name,firstname,birthDate) 
        {
            _directedMovies = new List<Movie>();

        }
        public bool addMovie(Movie movie)
        {
            if(_directedMovies.Contains(movie))
            {
                return false;
            }
            if(movie.Director == null)  movie.Director = this;
            _directedMovies.Add(movie);
            return true;
        }

        public IEnumerator<Movie> Movies()
        {
            return _directedMovies.GetEnumerator();
        }
    }
}
