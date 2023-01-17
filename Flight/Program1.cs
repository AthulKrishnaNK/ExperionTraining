using System;
using System.Collections;
using System.Collections.Immutable;
using System.Globalization;
using System.Xml.Linq;
// alphabetical order
public class Program1
{
    public static void Main(string[] args)
    {
        string[] arr1 = new string[10];
        string[] arr2 = new string[10];

        Console.Write("Type 10 passenger names :\n");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("passenger {0} : ", i + 1);
            arr1[i] = Console.ReadLine();
        }
        Console.WriteLine("\n Passenger List \n");
        int count = 1;
        foreach (string i in arr1)
        {
            Console.WriteLine("Passenger "+ count + " : "+ i);
            count++;

        }

        // Sorted list
        //int j = 1;
        //Array.Sort(arr1);
        //Console.WriteLine("\n Passengers in alphabetical order\n");
        //foreach (string i in arr1)
        //{  
        //    Console.WriteLine("Passenger " + j + " : " + i);
        //    j++;
        //}

        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    for (int j = 0; j < arr1.Length; j++)
        //    {
        //        if (arr1[i].CompareTo(arr1[j]) > 0)
        //        {
        //            arr2[i] = arr1[j];
        //            arr1[i] = arr1[j];
        //        }
        //        else
        //        {
        //            arr2[i] = arr1[i];
        //            arr1[i] = arr1[j];
        //        }
        //    }
        //    Console.WriteLine(arr2[i]);

        //}




    }
}

    


