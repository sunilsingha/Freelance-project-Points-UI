namespace PointsUI.Classes
{
    class User : AuditFields
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSuperUser { get; internal set; }
        
    }
}
