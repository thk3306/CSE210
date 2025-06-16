public class EternalGoal : Goal
    {
        public EternalGoal(string shortname, string description, string points) 
            : base(shortname, description, points)
        {
        }

        public override int RecordEvent()
        {
            Console.WriteLine($"Congratulations! You have completed the goal: {GetShortName()}");
            Console.WriteLine($"You have earned {GetPoints()} points!");
            return int.Parse(GetPoints());
        }

        public override string GetStringRepresentation()
        {
            return base.GetStringRepresentation();
        }
    }
