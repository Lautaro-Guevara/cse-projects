public class GoalManager{
    List<Goal> _goals = new List<Goal>();
    private int _score;


    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        
        int selectionNumber = 0;
        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number >= 1 && number <= 6)
                    {
                        selectionNumber = number;
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter a number from the menu: ");
                    }
                }
                else
                {
                    Console.Write("Invalid input. Please enter a number from the menu: ");
                }
            };

            if (selectionNumber == 1)
            {
                Console.WriteLine("You selected: Create New Goal");
                CreateGoal();
            }
            else if (selectionNumber == 2)
            {
                Console.WriteLine("You selected: List Goals");
                ListGoalDetails();
            }
            else if (selectionNumber == 3)
            {
                Console.WriteLine("You selected: Save Goals");
                SaveGoals();
            }
            else if (selectionNumber == 4)
            {
                Console.WriteLine("You selected: Load Goals");
                LoadGoals();
            }
            else if (selectionNumber == 5)
            {
                Console.WriteLine("You selected: Record Event");
                RecordEvent();
            }

        }while (selectionNumber != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                Console.WriteLine($"{count}. {goal.GetShortName()}");
                count++;
            }
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal()
    {
        int selectionNumber = 0;
        do
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.Write("Which type of goal would you like to create? ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number >= 1 && number <= 4)
                    {
                        selectionNumber = number;
                        if (number == 4)
                        {
                            Console.WriteLine("Exiting goal creation.");
                            break;
                        }
                        
                        Console.WriteLine(number);
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid input. Please enter a number from the menu: ");
                    }
                }
                else
                {
                    Console.Write("Invalid input. Please enter a number from the menu: ");
                }
            };

            if (selectionNumber == 4)
            {
                
                break; // Exit the goal creation loop
            }
            Console.WriteLine(selectionNumber);
            if (selectionNumber == 1 || selectionNumber == 2 || selectionNumber == 3)
            {
                Console.WriteLine();
                Console.WriteLine("You selected: " + (selectionNumber == 1 ? "Simple Goal" : selectionNumber == 2 ? "Eternal Goal" : "Checklist Goal"));
            }

            Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points;
                while (!int.TryParse(Console.ReadLine(), out points) || points < 0)
                {
                    Console.Write("Invalid input. Please enter a valid positive integer for points: ");
                }

            if (selectionNumber == 1) // Simple Goal
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points.ToString());
                _goals.Add(simpleGoal);

            }
            else if (selectionNumber == 2) // Eternal Goal
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points.ToString());
                _goals.Add(eternalGoal);
            }
            else if (selectionNumber == 3) // Checklist Goal
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target;
                while (!int.TryParse(Console.ReadLine(), out target) || target < 1)
                {
                    Console.Write("Invalid input. Please enter a valid positive integer for target: ");
                }
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus;
                while (!int.TryParse(Console.ReadLine(), out bonus) || bonus < 0)
                {
                    Console.Write("Invalid input. Please enter a valid positive integer for bonus: ");
                }
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points.ToString(), target, bonus);
                _goals.Add(checklistGoal);
            }

        } while (selectionNumber != 4);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        List<Goal> uncompletedGoals = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                uncompletedGoals.Add(goal);
            }
        }
        int goalNumber = int.Parse(Console.ReadLine());
        if (goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goal selectedGoal = uncompletedGoals[goalNumber - 1];
            selectedGoal.RecordEvent();
            _score += int.Parse(selectedGoal.GetPoints());

        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');
            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
                if (isComplete)
                {
                    simpleGoal.RecordEvent(); // Mark as complete
                }
                _goals.Add(simpleGoal);
            }
            else if (goalType == "EternalGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                for (int j = 0; j < amountCompleted; j++)
                {
                    checklistGoal.RecordEvent(); // Increment completion count
                }
                _goals.Add(checklistGoal);
            }
        }
    }

    
}