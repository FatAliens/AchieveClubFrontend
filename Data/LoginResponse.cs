namespace AchieveClubFrontend.Data
{
    public class LoginResponse
    {
        public int UserId { get; set; }
        public string AuthToken { get; set; }
        public string RefreshToken { get; set; }
        public string Message { get; set; }
    }

}
