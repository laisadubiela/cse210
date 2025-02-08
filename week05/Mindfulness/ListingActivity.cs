namespace Mindfulness {
    public class ListingActivity : Activity {
    int _count;
    List<string> _prompts;
        public ListingActivity(int menu) : base(menu) {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }
        public void Run(){
            StartMessage();
            GetRandomPrompt();
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            GetListFromUser();
            Console.WriteLine($"\nYou listed {_count} itens.\n");
            EndMessage();
        }

        public void GetRandomPrompt() {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            Console.WriteLine(_prompts[index]);
        }

        public List<string> GetListFromUser() {
            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input);
                    _count += 1;
                }
            }
            return _prompts;
        }

    }
}