namespace AlgorithmMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.DisplayMenu();
        }
    }
}

namespace AlgorithmMenu
{
    public static class Menu
    {
        // Här har vi skrivit en simpel meny för att hantera Uppgift 1 samt 2.1
        
        public static void DisplayMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Välj en uppgift att köra:");
                Console.WriteLine("1. Kombinera sorterade arrayer");
                Console.WriteLine("2. Sök största element och returnera index");
                Console.WriteLine("3. Avsluta");

                int choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        RunUppgift1();
                        break;

                    case 2:
                        RunUppgift2();
                        break;

                    case 3:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }

        private static void RunUppgift1()
            {   
                // Här skriver användaren in storleken på array 1.
                Console.WriteLine("Ange storleken på första arrayen:");
                int size1;
                while (!int.TryParse(Console.ReadLine(), out size1) || size1 <= 0)
                {
                    Console.WriteLine("Ogiltig inmatning. Ange ett positivt heltal för storleken på första arrayen:");
                }

                int[] arr1 = new int[size1];
                // Här skriver användaren in värden baserat på storleken av arrayen.
                Console.WriteLine("Ange elementen för första arrayen:");
                for (int i = 0; i < size1; i++)
                {
                    int element;
                    while (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("Ogiltig inmatning. Ange ett heltal för elementet:");
                    }
                    arr1[i] = element;
                }
                // Här skriver användaren in storleken på array 2.
                Console.WriteLine("Ange storleken på andra arrayen:");
                int size2;
                while (!int.TryParse(Console.ReadLine(), out size2) || size2 <= 0)
                {
                    Console.WriteLine("Ogiltig inmatning. Ange ett positivt heltal för storleken på andra arrayen:");
                }

                int[] arr2 = new int[size2];
                // Här skriver användaren in värden baserat på storleken av arrayen.
                Console.WriteLine("Ange elementen för andra arrayen:");
                for (int i = 0; i < size2; i++)
                {
                    int element;
                    while (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("Ogiltig inmatning. Ange ett heltal för elementet:");
                    }
                    arr2[i] = element;
                }

                // Här kombineras arrayerna med CombineSortedArrays funktionen.
                int[] combinedArray = Uppgift1.CombineSortedArrays(arr1, arr2);
                Array.Sort(combinedArray);

                // Här skrivs resultatet ut av den färdiga proccessen.
                Console.WriteLine("Den kombinerade och sorterade arrayen är:");
                foreach (int num in combinedArray)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        private static void RunUppgift2()
        {
            // Här skriver användaren in storleken på arrayen.
            Console.WriteLine("Ange storleken på arrayen:");
            int size = int.Parse(Console.ReadLine()!);
            int[] array = new int[size];
            
            // Här skriver användaren in värden som är baserat på arrayens storlek.
            Console.WriteLine("Ange elementen för arrayen:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine()!);
            }

            (int maxElement, int maxIndex) = Uppgift2.FindMaxElementAndIndex(array);
            
            // Här skrivs resultatet ut för vilket värde som är högst och vilket index värdet har.
            Console.WriteLine($"Det största elementet är {maxElement} och finns på index {maxIndex}.");
        }
    }
}
