using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine_01
{
    [Serializable]
    internal class Actor : Person
    {
        private static readonly long _serialVersionUID = 1L;
        private readonly int _sizeCentimeter;
        private List<Movie> _movies;

        public int SizeCentimenter
        {
            get { return _sizeCentimeter; }
        }

        public Actor(string name, string firstname, DateTime birthDate,
                    int sizeCentimeter) : base(name, firstname, birthDate) {
            this._sizeCentimeter = sizeCentimeter;
            _movies = new List<Movie>();
        }

        public override string ToString()
        {
            return "Actor [name = " + Name + " firstname = " + Firstname +
                ", sizeCentimeter =  " + SizeCentimenter + " birthdate = " + BirthDate +
                "]";
        }

        public IEnumerator<Movie> Movies()
        {
            return _movies.GetEnumerator();
        }

        public Boolean AddMovie(Movie movie)
        {
            if((movie == null) || _movies.Contains(movie))
            {
                return false;
            }
            if (movie.ContainsActor(this)){
                return false;
            }
            _movies.Add(movie);
            return true;
        }

        public Boolean ContainsMovie(Movie movie)
        {
            return _movies.Contains(movie);
        }

        public override string Name
        {
            get { return base.Name.ToUpper(); }
        }
    }
}
