// use a log to of how many times activities were performed

using System;
using System.Diagnostics;
using Microsoft.Win32.SafeHandles;
namespace Mindfulness {
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");

        int _menu = 9;
        int _times = 0;

        while (_menu != 4){
            _times += 1;
            Console.Write("Menu Options:\n1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Listening Activity\n4. Quit\nSelect a choice from the menu: ");
            _menu = int.Parse(Console.ReadLine());
            
            if (_menu == 1) {
                var activity = new BreathingActivity(_menu);
                activity.Run();
            }
            if (_menu == 2) {
                var activity = new ReflectionActivity(_menu);
                activity.Run();
            }
            if (_menu == 3) {
                var activity = new ListingActivity(_menu);
                activity.Run();
            }
            if (_menu == 4) {
                break;
            }
        }
        Console.WriteLine($"You have complete {_times} activities.");
    }
}
}