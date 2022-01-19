using System;
using global::System.Linq;
using global::System.Security.Policy;
using global::TP3_maxime_bertrand;
using TP3;

namespace TP3_maxime_bertrand
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var listmovie = new global::TP3.MovieCollection().Movies;

            var firstmovie = listmovie.OrderBy(x=>x.ReleaseDate).First().Title;
            Console.WriteLine(firstmovie);

            var countmovie = listmovie.Count();
            Console.WriteLine(countmovie);

            var countwithe = listmovie.Count(x=>x.Title.Contains('e'));
            Console.WriteLine(countwithe);

            var highbudget = listmovie.OrderBy(x => x.Budget).Last().Title;
            Console.WriteLine(highbudget);
            
            var lowbox = listmovie.OrderBy(x => x.BoxOffice).First().Title;
            Console.WriteLine(lowbox);
            
            var ordermovies = listmovie.OrderBy(x => x.Title).Take(11);
            Console.WriteLine(ordermovies);

            //var counteightees = listmovie.Count(x => x.ReleaseDate) < 1980;
            //Console.WriteLine(counteightees);

            var exo2 = new Exercice2();
            exo2.launch();

        }
    }
}