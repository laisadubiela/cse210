namespace Mindfulness {
    public class ReflectionActivity : Activity {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectionActivity(int menu) : base(menu) {
            _prompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };
            _questions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
        }

        public void Run() {
            StartMessage();
            DisplayPrompt();
            DisplayQuestion();
            EndMessage();
        }
    
        public string GetRandomPrompt() {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public string GetRandomQuestion() {
            Random random = new Random();
            int index = random.Next(_questions.Count);
            string _question = _questions[index];
            _questions.RemoveAt(index);
            return _question;
        }

        public void DisplayPrompt() {
            Console.WriteLine($"Consider the following prompt:\n --- {GetRandomPrompt()} ---\nWhen you have something in mind, press enter to continue: ");
            Console.ReadLine();
        }

        public void DisplayQuestion() {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowCountdown(_duration/2);
            Console.WriteLine($"> {GetRandomQuestion()}");
        }
    }
}