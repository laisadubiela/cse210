using System.Collections.Generic;

public class Answers
{

    public List<string> _answers = new List<string> { };

    public void GetAnswer(string _getQuestion, string _answer, string _date, string _mood)
    {
        string answer = "Date: " + _date + " - Prompt: " + _getQuestion + "\n" + _answer + "\n" + "Mood: " + _mood;
        _answers.Add(answer);
    }
}