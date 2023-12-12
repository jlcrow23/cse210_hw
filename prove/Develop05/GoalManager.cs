public class GoalManager
{
    private static List<Goals> goalList = new List<Goals>();
    private static int _score = 0;
    public List<Goals> GetList()
    {
        return goalList;
    }
    public static int GetScore()
    {
        return _score;
    }
    public static void SetPoints(int points)
    {
        _score = points;
    }
    
    public static void Start()
    {
        Console.Clear();

        // List<Goals> goals = new List<Goals>();

        while (true)
        {   
            
            

            Console.WriteLine("Welcome to your goals!\n");
            Console.WriteLine($"You have {SetPoints} points.\n");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Create a Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Completion");
            Console.WriteLine("6: Quit");

            int userPick = int.Parse(Console.ReadLine());

            if (userPick == 1)
            {
                
                Console.WriteLine("\nWhat type of goal would you like to make?");
                Console.WriteLine("1: Simple Goal");
                Console.WriteLine("2: Checklist Goal");
                Console.WriteLine("3: Eternal Goal\n");

                int userChoice = int.Parse(Console.ReadLine());

                while (true)
                {
                    if (userChoice == 1)
                    {
                        Console.WriteLine("What goal would you like to make?");
                        string sGoal = Console.ReadLine();
                        Console.WriteLine("Write a small description.");
                        string sDescrip = Console.ReadLine();
                        Console.WriteLine("How many points would you like to earn when complete?");
                        int sPoint = int.Parse(Console.ReadLine());

                        // goalList.Add(sGoal);

                        break;
                    }
                    if (userChoice == 2)
                    {
                        Console.Write("What goal would you like to accomplish? ");
                        string cGoal = Console.ReadLine();
                        Console.Write("Write a short description.");
                        string cDescrip = Console.ReadLine();
                        Console.Write("How many times would you like to do this activity?");
                        int cAmount = int.Parse(Console.ReadLine());
                        Console.Write("How many point is each completion worth?");
                        int cPoint = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for totally complete?");
                        int cBonus = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"\nYour checklist goal is {cGoal} completing it {cAmount} times at {cPoint} points each and a {cBonus} bonus when fully completed.\n");
                        break;

                    }
                    if (userChoice == 3)
                    {
                        Console.Write("What eternal goal would you like to make? ");
                        string eGoal = Console.ReadLine();
                        Console.Write("Write a short descripton. ");
                        string eDescrip = Console.ReadLine();
                        Console.Write("How many points is each completion worth?");
                        int ePoint = int.Parse(Console.ReadLine());
                        break;
                    }
                }
                
            }
            if (userPick == 2)
            {
                Console.WriteLine("You picked 2");
            }
            if (userPick == 3)
            {
                Console.WriteLine("You picked 3");
            }
            if (userPick == 4)
            {
                Console.WriteLine("you picked 4");
            }
            if (userPick == 5)
            {
                Console.WriteLine("You picked 5");
            }
            if (userPick == 6)
            {
                break;
            }
        }
        

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }

}