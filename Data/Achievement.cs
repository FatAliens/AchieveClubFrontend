namespace AchieveClubFrontend.Data
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Xp { get; set; }
        public string logoURL { get; set;}
        public int completionRatio { get; set; }
    }
}
