namespace PointsUI.Classes
{
    public class UserLoggedIn
    {
        private static UserLoggedIn _Instance;

        public static UserLoggedIn Instance()
        {
            if (_Instance == null)
            {
                _Instance = new UserLoggedIn();
            }
            return _Instance;
        }

        public bool IsAdmin { get; set; }
        public bool IsSuperUser { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
