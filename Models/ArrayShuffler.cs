using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShufle.Models
{
    public static class ArrayShuffler
    {
        public static T[] Shuffle<T>(T[] array)
        {
            Random rnd = new Random();

            int n = array.Length;

            for (int i = n - 1; i > 0; i--)
            {
                int newPos = rnd.Next(n);
                T value = array[newPos];

                array[newPos] = array[i];
                array[i] = value;
            }

            return array;
        }
    }
}
