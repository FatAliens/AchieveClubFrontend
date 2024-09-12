using AchieveClubFrontend.Data;

public class Club
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string LogoURL { get; set; }
    public int AvgXp { get; set; }
    public List<User> Users { get; set; }
    public int Position { get; set; }
}