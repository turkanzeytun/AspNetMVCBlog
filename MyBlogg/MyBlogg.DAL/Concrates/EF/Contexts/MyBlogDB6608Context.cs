using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MyBlogg.DAL.Concrates.EF.Mapping;
using MyBlogg.Model;

namespace MyBlogg.DAL.Concrates.EF.Contexts
{
    public partial class MyBlogDB6608Context : DbContext
    {
        static MyBlogDB6608Context()
        {
            Database.SetInitializer<MyBlogDB6608Context>(null);
        }

        public MyBlogDB6608Context()
            : base("Name=MyBlogDB6608Context")
        {
        }

        public DbSet<Blog_Makale> Blog_Makales { get; set; }
        public DbSet<MakaleKategori> MakaleKategoris { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<MakaleTur> MakaleTurs { get; set; }
        public DbSet<MakaleYorumlar> MakaleYorumlars { get; set; }
        public DbSet<YorumAtanBilgiler> YorumAtanBilgilers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Blog_MakaleMap());
            modelBuilder.Configurations.Add(new MakaleKategoriMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new MakaleTurMap());
            modelBuilder.Configurations.Add(new MakaleYorumlarMap());
            modelBuilder.Configurations.Add(new YorumAtanBilgilerMap());
        }
    }
}
