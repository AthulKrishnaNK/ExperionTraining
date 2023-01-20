//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Transactions;

//namespace Flight
//{
//    class Program4
//    {
//        public static void Main(string[] args)
//        {
//            DateTime dob = new DateTime();
//            Console.WriteLine("Enter your DOB: (YYYY-MM-DD)");
            //DateTime.TryParse(Console.ReadLine(), out dob);

//            DateTime TimeNow = new DateTime();
//            TimeNow = DateTime.Now;

//            //hours lived
//            Console.WriteLine("\n Age in Hours : " + (TimeNow - dob).TotalHours);

//            //Days lived
//            Console.WriteLine("\n Age in Days : " + (TimeNow - dob).TotalDays);

//            //Weeks lived
//            Console.WriteLine("\n Age in Weeks : " + ((TimeNow - dob).TotalDays)/7);

//            //Months lived
//            Console.WriteLine("\n Age in Months : " + ((TimeNow - dob).TotalDays )/30);

//            //Years lived
//            Console.WriteLine("\n Age in Years : " + ((TimeNow - dob).TotalDays)/365.25);

//            int year = dob.Year;
            
//                if (year % 4 == 0 && year % 400 == 0)
//                {
                    
//                    Console.WriteLine("\n You are born in a leap year");
//                }
//                else
//                {
                    
//                    Console.WriteLine("\n" + year + " is not a leap year");
//                }
            

            

//        }
//    }
//}
