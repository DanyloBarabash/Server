using System.Data.Entity;

namespace DBAcademy
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Test> Tests { get; set; }
    }
}
