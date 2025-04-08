using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();

        int totalPoints = 0;
        bool quit = false;

       

        while (quit == false)
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu:");

            string incomingChoice = Console.ReadLine();


            if (incomingChoice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?:");

                string goalChoice = Console.ReadLine();
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                
                
                if (goalChoice == "1")
                {
                    goalList.Add(new Simple(name, description, points));
                }

                else if (goalChoice == "2")
                {
                    goalList.Add(new Eternal(name, description, points));
                }

                else if (goalChoice == "3")
                {
                    Console.Write("How many times does this goal need to be completed? ");
                    int count = int.Parse(Console.ReadLine());

                    int target = count;

                    int current = 0;

                    Console.Write("What is the bonus for completing it? ");
                    int bonus = int.Parse(Console.ReadLine());

                    goalList.Add(new Checklist(name, description, points, target, current, bonus));
                }

            }

            else if (incomingChoice == "2")
            {
                Console.WriteLine("Here are the goals:");
                foreach (Goal goalitem in goalList)
                {
                    string isTheGoalComplete;
                    if (goalitem.Completed() == true)
                    {
                        isTheGoalComplete = "[x]";
                    }
                    else
                    {
                        isTheGoalComplete = "[]";
                    }


                    if (goalitem is Checklist checklistGoal)
                    {
                        Console.WriteLine($"{isTheGoalComplete} {goalitem.Name()}: {goalitem.Description()} {checklistGoal.CurrentCount()} / {checklistGoal.TargetCount()} ");
                    }
                    else
                    {
                        Console.WriteLine($"{isTheGoalComplete} {goalitem.Name()}: {goalitem.Description()}");
                    }
                    

                    
                }

                
            }

            else if (incomingChoice == "3")
            {
                
                string fileName = "goals.txt";

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"Points:{totalPoints}");

                    foreach (Goal goalitem in goalList)
                {
                    outputFile.WriteLine(goalitem.GetStringRepresentation());

                }
    

                }
            }

            else if (incomingChoice == "4")
            {
                goalList.Clear();
                string[] lines = File.ReadAllLines("goals.txt");

                totalPoints = 0;

                foreach (string line in lines)
                {
                    string[] typeSplit = line.Split(':');
                    string type = typeSplit[0];
                    string details = typeSplit[1];

                    if (type == "Simple")
                    {
                        goalList.Add(Simple.CreateFromString(details));
                    }
                    else if (type == "Eternal")
                    {
                        goalList.Add(Eternal.CreateFromString(details));
                    }
                    else if (type == "Checklist")
                    {
                        goalList.Add(Checklist.CreateFromString(details));
                    }

                }
                Console.WriteLine("Goals loaded!");

            }
                

            else if (incomingChoice == "5")
            {
                Console.WriteLine("Which goal did you accomplish?");
                for (int i = 0; i < goalList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goalList[i].Name()}");
                }

                int selected = int.Parse(Console.ReadLine()) - 1;

                if (selected >= 0 && selected < goalList.Count)
                {
                    Goal goal = goalList[selected];
                    int beforePoints = totalPoints;
                    goal.RecordEvent();
                    
                    if (goal is Checklist checklistGoal)
                    {
                        if (checklistGoal.Completed())
                        {
                            totalPoints += checklistGoal.GetPoints() + checklistGoal.GetBonus();
                        }
                        else
                        {
                            totalPoints += checklistGoal.GetPoints();
                        }
                    }
                    else if (goal is Simple simpleGoal)
                    {
                        if (simpleGoal.Completed())
                        {
                            totalPoints += simpleGoal.GetPoints();
                        }
                    }
                    else
                    {
                        totalPoints += goal.GetPoints();
                    }
                }
            }


            else if (incomingChoice == "6")
            {
                quit = true;
            }
        }
        
    }
}


/*
Just to note, I did use ai to help me understand the concenpts and broaden my view of the code.
I also used it for bug fixing such as when I couldn't understand why the simple class wasn't being marked as completed.
I understand everything that is going on with the current code and I know what everything means.
You can call or email me and quiz me if you are unsure. To me, AI is a tutor that allows me to ask real time quiestions
when you, or my fellow students are asleep. I use AI to expand what i understand that code can do.
One way i used ai was to explain what (!_complete) means. I found out that ! is the "not" operator
and means that whatever _complete means is not true. So if i had code that said, if (!_complete) and _complete was false, 
then the if statement would be sayin, "if not false..." 
Hoenstly, this program was very difficult for me and there is still a major bug i cannot figure out.
I can save goals, and I can also list them. I can load them as well...
But when I save a goal, exit the progam, list the goals i get nothing. (which is expected.)
If i then try to load the program without exiting, I don't see any goals at all...
If i open up the program and go right to loading a goal, it works!
I tried using ai to help me accomplish it, but it's solution was too complex for me to make sense of at night considering i have spent the last 8 hours doing
this asignment...
Anyway, I still technically acoomplished the goal!!!
so.... please have mercy on me
*/
