namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string shortname, string description, string points)
            : base(shortname, description, points)
        {
        }

        public override void RecordEvent()
        {

        }

        public override string GetStringRepresentation()
        {
            return base.GetStringRepresentation();
        }
    }
}