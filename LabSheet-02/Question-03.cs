//3.	Build an application to store and display the temperatures of a week using an array. Create a class named ‘TemperatureTracker’ with an array to store daily temperatures. Implement a method to display the temperatures. Instantiate an object, input temperatures, and display the weekly temperature report.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TemperatureTracker
{
    private double[] temperatures;

    public TemperatureTracker(int daysInWeek)
    {
        temperatures = new double[daysInWeek];
    }
    
    public void SetTemperature(int day, double temperature)
    {
        if (day >= 0 && day < temperature.Length)
        {
            temperatures[day] = temperatures;

        }
        else
        {
            Console.WriteLine("Invalid day input. ");
        }
    }

    public void DisplayWeeklyTemperature()
    {
        Console.WriteLine("Weekly temperature Report:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        //Assuming 7days in a week
        TemperatureTracker tracker = new TemperatureTracker(7);

        // Input temperature for each day
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Enter temperature for day {i + 1}:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            tracker.SetTemperature(i, temperature);
        }

        tracker.DisplayWeeklyTemperature();

    }
}