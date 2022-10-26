using MovieDbLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDbLab
{
    public class Movies
    {

        public List<string> SearchByGenere()
        {
            MoviesContext mc = new MoviesContext();
            List<MovieInventory> movies = mc.MovieInventories.ToList();
            List<string> search = new List<string>();


            Console.WriteLine("Type the genre you would like to view, here are the options:");
            string userinput = Console.ReadLine();



            List<string> movieGeneres = new List<string>();
            foreach (MovieInventory movie in movies)
            {
                if (movieGeneres.Contains(movie.Genere) == false)
                {
                    movieGeneres.Add(movie.Genere);
                }
            }


            foreach (string mo in movieGeneres)
            {
                Console.WriteLine(mo);
            }





            Console.WriteLine("The movies with those genre avaliable are.");
            List<string> SelectedMovies = new List<string>();
            foreach (MovieInventory movie in movies)
            {
                if (movie.Genere.Contains(userinput))
                {
                    search.Add(movie.MovieName);
                }
            }
            return search;
        }


        public List<string> SearchbyTitle()
        {
            List<MovieInventory> search = new List<MovieInventory>();
            MoviesContext mc = new MoviesContext();

            Console.WriteLine("Type in the title yo are looking for.");
            string userinput = Console.ReadLine();

            Console.WriteLine();

            List<string> movieNames = new List<string>();

            search = mc.MovieInventories.Where(m => m.MovieName.Contains(userinput)).ToList();

            return search.Select(m => m.MovieName).ToList();
        }






        public void ReturnedTitle(List<string> titlereturn)
        {
            MoviesContext mc = new MoviesContext();
            List<MovieInventory> movies = mc.MovieInventories.ToList();

            Console.WriteLine("Select a Movie");
            int i = 1;
            foreach (string movie in titlereturn)
            {
                Console.WriteLine($"|{i}| {movie}");
                i++;
            }

            int userinput = int.Parse(Console.ReadLine());
            string chosenmovie = titlereturn[userinput - 1];

            foreach (MovieInventory moves in movies)
            {

                if (chosenmovie.Equals(moves.MovieName))
                {
                    Console.WriteLine($"Movie Title:{moves.MovieName} \nMovie Genere:{moves.Genere} \nMovie Run Time: {moves.RunTime}");
                    break;
                }

            }

        }




    }
}
