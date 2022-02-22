using System;
using System.Collections.Generic;

namespace SemihCelek.Champions_League.Utils
{
    public static class Shuffle
    {
        private static Random _random = new Random();

        private static void Shuffler<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<T> ShuffleList<T>(List<T> list)
        {
            list.Shuffler();
            return list;
        }
        
    }
}