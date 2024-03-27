// Detta är en såkallad "merge"-algorithm som används för att kombinera 2 arrayer. Den tar två inputs, Storleken på arrayen, 
// samt värdena i dessa arrayer och kombinerar och sorterar dem efter storleks ordning.
using System;
using System.Globalization;

namespace AlgorithmMenu
{
    public static class Uppgift1
    {
        // Först skapar vi en array för att hålla de kombinerade och sorterade elementen.
        
        public static int[] CombineSortedArrays(int[] arr1, int[] arr2) // O(n)
        {
            DateTime startTime = DateTime.Now;
            
            if (arr1.Length == 0)
            {
                return arr2;
            }
            else if (arr2.Length == 0)
            {
                return arr1;
            }
            // Vi skapar ett index.
            int[] combinedArray = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            
            // Om det finns färre element i den första arrayen än vad det finns i den andra arrayen,
            // Så läggs det till i den kombinerade arrayen och index för den första arrayen flyttas framåt.
            // Annars, läggs element index från andra arrayen till och flyttas framåt.
            
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    combinedArray[k++] = arr1[i++];
                }
                
                else
                {
                    combinedArray[k++] = arr2[j++];
                }
            }
            
            // När arrayerna är jämförda och kombinerade och alla element från båda arrayerna är korrekt
            // läggs resterande element som finns kvar i den nya arrayen.

            while (i < arr1.Length)
            {
                combinedArray[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                combinedArray[k++] = arr2[j++];
            }
            // Sedan visar den nya arrayen där allt är kombinerat och sorterat.
            DateTime stopTime = DateTime.Now; // Sparar sluttid
            TimeSpan duration = stopTime - startTime; // Beräknar tidsåtgången
            
            // Skriver ut hur lång tid operationen tog på ett mer lättläst sätt
            Console.WriteLine($"Tid: {duration.TotalMilliseconds} msec");
            Console.WriteLine(stopTime -startTime);
            return combinedArray;
        }
    }
}