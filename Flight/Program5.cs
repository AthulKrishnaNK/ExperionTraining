class Program5
{

    public static void Main()
    {
        Double[] fare = new Double[5];
        Double[] fares = new Double[10];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter Flight fare {0}: ", i + 1);
            fare[i] = Double.Parse(Console.ReadLine());


        }
        Console.WriteLine("\n");
        foreach (int i in fare)
        {
            Console.WriteLine(i);
        }

        int odd = 0;
        int even = 1;

        for (int i = 0; i < 5; i++)
        {


            if (fare[i] % 2 != 0)
            {
                fares[odd] = fare[i];
                odd += 2;
            }
            else
            {
                fares[even] = fare[i];
                even += 2;
            }
        }
        Console.WriteLine("\n");
        foreach (Double item in fares)
        {
            Console.WriteLine(item);
        }
    }

}
