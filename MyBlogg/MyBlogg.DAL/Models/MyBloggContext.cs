using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MyBlogg.DAL.Models.Mapping;

namespace MyBlogg.DAL.Models
{
    public partial class MyBloggContext : DbContext
    {
        static MyBloggContext()
        {
            Database.SetInitializer<MyBloggContext>(null);
        }

        public MyBloggContext()
            : base("Name=MyBloggContext")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SubjectCategory> SubjectCategories { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new SubjectCategoryMap());
            modelBuilder.Configurations.Add(new SubjectMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
