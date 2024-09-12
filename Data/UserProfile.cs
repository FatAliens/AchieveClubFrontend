namespace AchieveClubFrontend.Data
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubLogo { get; set; }
        public int XpSum { get; set; }
    }
}
