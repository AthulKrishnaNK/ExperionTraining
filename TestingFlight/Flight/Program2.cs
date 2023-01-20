using System;
//Accepting the fare Charge.
Console.Write("Enter the Flight fare (Enter Numbers Only): ");
var flightFare = Console.ReadLine();
var fare = 0;
if (flightFare != null)
{
    fare = Int32.Parse(flightFare);
}
Console.WriteLine("The fare for flight is " + flightFare);

//Accepting the Time of booking.
DateTime bookingDateTime;
int time = 0;
Console.Write("Enter the date and time of booking (format YYYY-MM-DD HH:MM:SS)");
if (DateTime.TryParse(Console.ReadLine(), out bookingDateTime))
{
    Console.WriteLine("The time of the booking is: " + bookingDateTime.TimeOfDay);
    time = bookingDateTime.TimeOfDay.Hours;
}
else
{
    Console.WriteLine("You have entered an incorrect value.");
}

//Sorting fare with respect to charge.
if (time > 6 && time < 9)
{
    int newFare = (int)(fare + (fare * 0.1));
    Console.WriteLine("The final fare charge is " + newFare);
}
else if (time >= 9 && time < 17)
{
    int newFare = (int)(fare + (fare * 0.2));
    Console.WriteLine("The final fare charge is " + newFare);
}
else if (time >= 17 && time < 23)
{
    int newFare = (int)(fare + (fare * 0.07));
    Console.WriteLine("The final fare charge is " + newFare);
}
else
{
    int newFare = (int)(fare + (fare * 0.05));
    Console.WriteLine("The final fare charge is " + newFare);
}