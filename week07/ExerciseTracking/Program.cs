using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> acivities = new List<Activity>();
        Running run = new Running(DateTime.Now, 120, 10);
        Cycling cycle = new Cycling(DateTime.Now, 60, 20);
        Swimming swim = new Swimming(DateTime.Now, 30, 20);
        acivities.Add(run);
        acivities.Add(cycle);
        acivities.Add(swim);
        foreach (Activity activity in acivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}