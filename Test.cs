using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine_01
{
    internal class Test
    {
        public static void Main(string[] args, IEnumerator<Movie> moviesIt)
        {
            Actor[] myActors =
            {
                new Actor("Assange", "Julien", new DateTime(1991, 7, 3), 187),
                new Actor("Paul", "Newmann", new DateTime(1925, 1, 26), 187),
                new Actor("Becker", "Norma Jean", new DateTime(1926, 6, 1), 187),
            };
            Director[] myDirectors =
            {
                new Director("Spielberg", "Steven", new DateTime(1948, 12, 18)),
                new Director("Coen", "Ettan", new DateTime(1957, 9, 21)),
                new Director("Coppolla", "Frncis Ford", new DateTime(1939, 4, 7)),
            };

            Movie bigLebow = new Movie("The Big Lebowski", 1996);
            Movie eT = new Movie("E.T.", 1982);

            eT.AddActor(myActors[0]);
            eT.AddActor(myActors[2]);
            eT.Director = myDirectors[0];

            bigLebow.AddActor(myActors[0]);
            bigLebow.AddActor(myActors[2]);
            bigLebow.Director = myDirectors[1];

            PersonList myPersons = PersonList.getInstance();

            foreach (Actor act in myActors)
            {
                myPersons.AddPerson(act);
            }
            foreach( Director dir in myDirectors)
            {
                myPersons.AddPerson(dir);
            }
            IEnumerator<Person> ActorIt = myPersons.personList();
            while (ActorIt.MoveNext())
            {
                Person person = ActorIt.Current;
                Console.WriteLine(person);

                IEnumerator<Movie> MoviesIt;
                if(person is Actor)
                {
                    Console.WriteLine("à joué dans les films suivant");
                    MoviesIt = ((Actor)person).Movies();
                } else
                {
                    if (person is Director)
                    {
                        Console.WriteLine("à dirigé les films suivants : ");
                        MoviesIt = ((Director)person).Movies();
                    }
                    else
                    {
                        Console.WriteLine("est inconnu et n'a rien à faire ici");
                    }
                }
                while (moviesIt.MoveNext())
                {
                    Movie Movie = moviesIt.Current;
                    Console.WriteLine(Movie);
                }
                {

                }
            }
        }
    }
}
