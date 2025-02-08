using System.Security.Cryptography.X509Certificates;

public class Activity {
    private string _activityName;
    private string _description;
    protected int _duration;

    public Activity(int menu){
        if (menu == 1) {
            _activityName = "Breathing Activity";
            _description = "relay by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        if (menu == 2) {
            _activityName = "Reflection Activity";
            _description = "reflect on times in your life when you have shown strenght and resilience. This will help you recocnize the power you have and how you can use it in other aspects of your life.";
        }
        if (menu == 3) {
            _activityName = "Listening Activity";
            _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
    }

    public void StartMessage() {
        Console.Write($"\nWelcome to the {_activityName}.\n\nThis activity will help you {_description}\n\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("");
    }

    public void EndMessage() {
        Console.WriteLine($"\nWell done!!\n\nYou have complete another {_duration} seconds of the {_activityName}.\n");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds) {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

