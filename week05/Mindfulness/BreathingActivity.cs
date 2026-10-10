using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        bool breatheIn = true;
        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.Write("\nBreathe in... ");
                ShowCountDown(4);
            }
            else
            {
                Console.Write("\nNow breathe out... ");
                ShowCountDown(6);
            }
            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}