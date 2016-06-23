using System;
using System.Collections.Generic;
using System.Linq;


namespace CodilityWorkShop
{
    class Program
    {
        static void Main()
        {
            Finder find = new Finder();
            int[] arr = {-1, 6, 3, 1, 2, 5};
            find.Solution(arr, arr.Length);

        }
    }
}
