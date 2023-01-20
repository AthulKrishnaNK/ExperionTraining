//using System.Security.Cryptography.X509Certificates;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//    class Program3
//    {
//        //Accept 10 flight fares in decimal format into an array.

//        public static void Main(string[] args)
//        {
//            int n = 10;
//            double[] flightFare = new double[n];
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("Enter the Flight Fare: ");
//                flightFare[i] = Convert.ToDouble(Console.ReadLine());
//            }

//            Console.WriteLine();

//            //Print ascending order.
//            Array.Sort(flightFare);
//            Console.WriteLine("Flight Fare sorted in ascending order");
//            foreach (double fare in flightFare)
//            {
//                Console.WriteLine(fare);
//            }

//            //System.Program3.WriteLine();

//            //Print descending order.
//            Array.Sort(flightFare);
//            Array.Reverse(flightFare);
//            Console.WriteLine("Flight Fare sorted in descending order");
//            foreach (double fare in flightFare)
//            {
//                Console.WriteLine(fare);
//            }

//            Console.WriteLine();

//            //Input a fare and search in array and display.
//            Console.Write("Search: ");
//            double search = Convert.ToDouble(Console.ReadLine());
//            int count = 0;
//            foreach (double fare in flightFare)
//            {
//                if (search == fare)
//                {
//                    count++;
//                    continue;
//                }
//            }
//            if (count == 0)
//            {
//                Console.WriteLine("Not Found");
//            }
//            else
//            {
//                Console.WriteLine("Found " + count + " results for " + search);
//            }

//            Console.WriteLine();

//            //Print the max and min fares.
//            Array.Sort(flightFare);
//            Console.WriteLine("Maximum fare charge: " + flightFare[n - 1]);
//            Console.WriteLine("Minimum fare charge: " + flightFare[0]);

//            Console.WriteLine();

//            //Print duplicate elements.
//            count = 0;
//            string message = "No duplicates were found.";
//            List<double> duplicates = new List<double>();
//            for (int i = 0; i < flightFare.Length; i++)
//            {
//                for (int j = i + 1; j < flightFare.Length; j++)
//                {
//                    if (flightFare[i] == flightFare[j] && !duplicates.Contains(flightFare[i]))
//                    {
//                        duplicates.Add(flightFare[i]);
//                        count++;
//                        message = "Duplicates Found";
//                    }
//                }
//            }
//            Console.WriteLine($"{count} {message}");
//            foreach (double fare in duplicates)
//            {
//                Console.WriteLine(fare);
//            }
//        }
    
//    }

