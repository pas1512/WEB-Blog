namespace ASP.DBTables
{
    public class Comment
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }
        public Comment? Parent { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string Content { get; set; }
        public string Date { get; set; }
        public int Rate { get; set; }
    }
}
