// Denna algorithm går igenom en array och letar efter det största värdet, sedan berättar den för användaren resultatet,
// som då är "Största värdet" samt vilken plats värdet ligger på i arrayen.
using System;
using System.Globalization;
namespace AlgorithmMenu
{
    public static class Uppgift2
    {
        // Först skapar vi variabler för att hålla det största elementet och vilken indexplats den skall ha.
        public static (int, int) FindMaxElementAndIndex(int[] array) // O(n)
        {
            DateTime startTime = DateTime.Now;
            
            int maxElement = array[0];
            int maxIndex = 0;
            // Eftersom vi satt Index 0 till att vara det största värdet, skapar vi en loop som nu ska kolla om näst kommande
            // värde är högre för att sedan kunna ersätta original värdet.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    //Om värdet är större, uppdateras index med det nya värdet.
                    maxElement = array[i];
                    maxIndex = i;
                }
            }
            // När den har kört klart iterationen kommer den nu visa det nya största värdet i index
            // samt berätta vilken position värdet har i index.
            
            DateTime stopTime = DateTime.Now; // Sparar sluttid
            TimeSpan duration = stopTime - startTime; // Beräknar tidsåtgången
            
            // Skriver ut hur lång tid operationen tog på ett mer lättläst sätt
            Console.WriteLine($"Tid: {duration.TotalMilliseconds} msec");
            Console.WriteLine(stopTime -startTime);
         
            return (maxElement, maxIndex);
        }
    }
}
