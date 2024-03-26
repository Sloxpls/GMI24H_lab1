namespace lab1;
using System;

//Generate a array of random numbers
//array size depens in funktion input 
public class RandomArray
{
    public static int[] Create(int iterations)
    {
        Random randomGenerator = new Random();
        int[] randomArray= new int[iterations];
        
        for (int i = 0; i < iterations; i++)
        {
            randomArray[i] = randomGenerator.Next(1, iterations);
        }
        
        return randomArray;
    }
}