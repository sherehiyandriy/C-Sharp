﻿namespace radix_sort
{
    internal class Program
    {
        /// <summary>
        /// Radix sort is a non-comparative integer sorting algorithm that sorts data with integer keys by grouping keys by the individual
        /// digits which share the same significant position and value. A positional notation is required, but because integers can represent
        /// strings of characters (e.g., names or dates) and specially formatted floating point numbers, radix sort is not limited to integers.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="bits">The bits.</param>
        public static void RadixSort(ref int[] x, int bits)
        {
            var b = new int[x.Length];
            var rshift = 0;
            for (var mask = ~(-1 << bits); mask != 0; mask <<= bits, rshift += bits)
            {
                var cntarray = new int[1 << bits];
                foreach (var t in x)
                {
                    var key = (t & mask) >> rshift;
                    ++cntarray[key];
                }

                for (var i = 1; i < cntarray.Length; ++i)
                {
                    cntarray[i] += cntarray[i - 1];
                }

                for (var p = x.Length - 1; p >= 0; --p)
                {
                    var key = (x[p] & mask) >> rshift;
                    --cntarray[key];
                    b[cntarray[key]] = x[p];
                }

                var temp = b;
                b = x;
                x = temp;
            }
        }
    }
}
