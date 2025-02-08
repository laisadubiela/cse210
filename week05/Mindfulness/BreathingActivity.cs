namespace Mindfulness {
    public class BreathingActivity : Activity {
        public BreathingActivity(int menu) : base(menu) {

        }
        public void StartActivity(){
            int cycles = _duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
        }
        }
        public void Run() {
            StartMessage();
            StartActivity();
            EndMessage();
        }
    }
}