using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(75, 5);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(120, 10);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(200, 40);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}