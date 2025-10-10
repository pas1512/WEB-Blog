namespace ASP.DBTables
{
    public class Blog
    {
        public int Id { get; set; }
        public string Header { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public int Rate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public Teg[] Tegs { get; set; } = null;
    }
}
