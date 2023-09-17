using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine_01
{
    internal class Movie
    {
        private string _title;
        private int _realeaseYear;
        private IList<Actor> _actors;
        private Director _director;

       
        public Movie(string title, int realeaseYear)
        {
            this._title = title;
            this._realeaseYear = realeaseYear;
        }

        public Director Director {
            get { return _director; }
            set
            {
                if (value == null) return;
                this._director = value;
                _director.addMovie(this);
            }
        }


        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int ReleaseYear
        {
            get => _realeaseYear;
            set { _realeaseYear = value;}
        }
        public Boolean AddActor(Actor actor)
        {
            if(_actors.Contains(actor))
            {
                return false;
            }
            _actors.Add(actor);
            if (!actor.ContainsMovie(this))
            {
                actor.AddMovie(this);
            }
            return true;
        }

        public Boolean ContainsActor(Actor actor)
        {
            return _actors.Contains(actor);

        }

        public override string ToString()
        {
            return "Movie [title=" + _title + ", releaseYear=" + _realeaseYear + "]";
        }
    }
}
