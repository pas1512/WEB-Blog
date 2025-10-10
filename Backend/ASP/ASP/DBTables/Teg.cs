namespace ASP.DBTables
{
    public class Teg
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Blog[] Blogs { get; set; } = null;
    }
}
