namespace ASP.DBTables
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public int Rate { get; set; }
    }
}
