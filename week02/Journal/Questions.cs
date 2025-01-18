using System;

public class Questions
{
    public List<string> questions = new List<string> {"If I had one thing I could do over today, what would it be?", 
    "What part of the day I am more greatful for?", 
    "What happen today that I don't want to forget", 
    "What could I have done better?"};
    
    public string GetQuestion()
    {
        Random random = new Random();
        int _index = random.Next(questions.Count);
        string _question = questions[_index];
        questions.RemoveAt(_index);
        return _question;
    }
}