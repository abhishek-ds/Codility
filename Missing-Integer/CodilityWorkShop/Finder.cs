using System;
using System.Collections.Generic;

namespace CodilityWorkShop
{
    class Finder
    {
       public void Solution(int[] intArray, int arrayLength)
        {
            Array.Sort(intArray);
            int i = 1;
           
            while (i< arrayLength)
           {
               if (((IList<int>)intArray).Contains(i))
               {
                   i++;
               }

               else
               {
                    Console.WriteLine(i);
                    i = arrayLength;
               }
           }
           Console.ReadLine();
        }
    }
}
