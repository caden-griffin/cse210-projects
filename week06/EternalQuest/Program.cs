using System;

class Program
{
    // EXCEEDING REQUIREMENTS:
    // To show creativity and exceed the core requirements, this program includes 
    // a Dynamic Leveling System integrated into the GoalManager. Players gain a new 
    // level automatically for every 1,000 points they accumulate, and the interface 
    // tracks their progress and points remaining until the next level.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}