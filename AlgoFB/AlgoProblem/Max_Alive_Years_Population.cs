using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        //ref: https://massivealgorithms.blogspot.com/2016/07/living-people.html
        public static int Max_Alive_Years_Population(List<People> people)
        {
            var minimum_birthYear = people.Select(x => x.BirthYear).OrderBy(x=>x).ToArray();
            var max_deathYear = people.Select(x => x.DeathYear).OrderBy(x=>x).ToArray();

            /*
             2001 2005
             2001 2004

             */

            int people_count = people.Count;
            int min = 0;
            int max = 0;
            int alive = 0;
            int which_year = 0;
            int max_avlie = 0;
            while (min < people_count && max < people_count)
            {
                if (minimum_birthYear[min] <= max_deathYear[max])
                {
                    alive++;
                    if (alive > max_avlie)
                    {
                        max_avlie = alive;
                        which_year = minimum_birthYear[min];
                    }
                    min++;
                }
                else
                {
                    alive--;
                    max++;
                }
            }
            return which_year;
        }

        //private static int[] Create_Year_Map(List<People> people, int minimum_birthYear, int max_deathYear)
        //{
        //    int[] ranges = new int[max_deathYear - minimum_birthYear + 1];

        //    for (int i = minimum_birthYear; i < max_deathYear; i++)
        //    { 
        //        increaseRanges 
        //    }
        //}
    }
}
