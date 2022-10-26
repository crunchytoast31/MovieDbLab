using MovieDbLab.Models;

namespace MovieDbLab
{
    internal class Program
    {
        static void Main()
        {
            MoviesContext mc = new MoviesContext();
            List<MovieInventory> movies = mc.MovieInventories.ToList();

            Movies mov = new Movies();

            List<string> list = mov.SearchByGenere();
            mov.ReturnedTitle(list);


            List<string> list2 = mov.SearchbyTitle();
            mov.ReturnedTitle(list2);

        }






    }
}