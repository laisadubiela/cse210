public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    private int _level;
    private int _pointsForNextLevel;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
        _pointsForNextLevel = 1000;
    }

    public void Start()
    {
        int _userOption = 0;
        
        while (_userOption != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Exit");
            Console.Write("Select a choice from the menu: ");
            _userOption = int.Parse(Console.ReadLine());

        if (_userOption == 1)
            {
                CreateGoal();
            }
            else if (_userOption == 2)
            {
                ListGoalDetails();
            }

            else if (_userOption == 3)
            {
                SaveGoals();
            }
            
            else if (_userOption == 4)
            {
                LoadGoals();
            }

            else if (_userOption == 5)
            {
                RecordEvent();
            }
       }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        
        Console.WriteLine("");
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        int goalOption = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of your goal? ");
        string _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        if (goalOption == 1)
        {
            _goals.Add(new SimpleGoal(_name, description, points));
        }
        else if (goalOption == 2)
        {
            _goals.Add(new EternalGoal(_name, description, points));
        }
        else if (goalOption == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(_name, description, points, target, bonus));
        }
        }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine("Which goal did you accomplish?");
        int _goalOption = int.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[_goalOption];
        goal.RecordEvent();
        
        string details = _goals[_goalOption].GetStringRepresentation();
        string[] parts = details.Split(',', ':'); 
        int points = 0;
        foreach (string part in parts)
        {
            if (int.TryParse(part.Trim(), out points))
            {
                break;
            }
        }
        _score += points;
        if (goal is ChecklistGoal checklistGoal)
    {
        if (checklistGoal.IsComplete())
        {
            _score += checklistGoal.Bonus;
        }
    }

    CheckLevelUp();
    }
    
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length < 2)
                    {
                        Console.WriteLine("Invalid goal format in file.");
                        continue;
                    }
                    string type = parts[0];
                    string[] details = parts[1].Split(',');
                    if (details.Length < 3)
                    {
                        Console.WriteLine("Invalid goal details in file.");
                        continue;
                    }

                    switch (type)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(details[0], details[1], details[2]));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(details[0], details[1], details[2]));
                            break;
                        case "ChecklistGoal":
                            _goals.Add(new ChecklistGoal(details[0], details[1], details[2], int.Parse(details[3]), int.Parse(details[4])));
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void CheckLevelUp()
    {
        while (_score >= _pointsForNextLevel)
        {
            _level++;
            _pointsForNextLevel += 500;
            Console.WriteLine($"Congratulations! You leveled up to Level {_level}!");
        }
    }
}