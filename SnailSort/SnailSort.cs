using System.Collections.Generic;
using System.Linq;

namespace SnailSort
{
    public class SnailSortKata
    {
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0)
                return new int[]{};

            if (array.Length == 1)
                return array[0];

            var limit = array.Length - 1;
            List<int> snail = array[0].Take(limit).ToList();

            for (int line = 0; line < limit; line++)
                snail.Add(array[line][limit]);

            snail.AddRange(array[limit].Skip(1).Take(limit).Reverse());

            for (int line = limit; line > 0; line--)
                snail.Add(array[line][0]);

            var inner = new int[limit - 1][];

            for (int line = 1; line < limit; line++)
            {
                inner[line - 1] = array[line].Skip(1).Take(limit - 1).ToArray();
            }

            snail.AddRange(SnailSortKata.Snail(inner));
            return snail.ToArray();
        }
    }
}

