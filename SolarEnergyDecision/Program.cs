using System;
  public class Program
    {
       public static void Main(string[] args)
        {

        bool isSunny = true;
        double windSpeed = 5.4;
        int temperature = 25;
        int solarPanelOutput = 9;
        bool isCloudy = false;

        bool result = isSunny && windSpeed < 10 && solarPanelOutput < 15 && (temperature > 20 || !isCloudy);

        Console.WriteLine("Checking conditions for solar energy production...");
        Console.WriteLine("1. Is it sunny? " + isSunny);
        Console.WriteLine("2. Is wind speed safe? " + (windSpeed < 10));
        Console.WriteLine("3. Can panels produce more? " + (solarPanelOutput < 15));
        Console.WriteLine("4. Is temperature good OR no clouds? " + (temperature > 20 || !isCloudy));
        Console.WriteLine("\nFinal result - Good day for solar production : " + result);
        }
    }

