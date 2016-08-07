using MyBlogg.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Concrates.EF.Mapping
{
    public class Blog_MakaleMap : EntityTypeConfiguration<Blog_Makale>
    {
        public Blog_MakaleMap()
        {
            // Primary Key
            this.HasKey(t => t.b_MakaleID);

            // Properties
            this.Property(t => t.b_MBaslik)
                .HasMaxLength(50);

            this.Property(t => t.b_MIcerik)
                .HasMaxLength(1000);
            this.Property(t => t.b_MResim1)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Blog_Makales");
            this.Property(t => t.b_MakaleID).HasColumnName("b_MakaleID");
            this.Property(t => t.b_MBaslik).HasColumnName("b_MBaslik");
            this.Property(t => t.b_MIcerik).HasColumnName("b_MIcerik");
            this.Property(t => t.b_MMKategoryID).HasColumnName("b_MMKategoryID");
            this.Property(t => t.b_MTur).HasColumnName("b_MTur");
            this.Property(t => t.b_MResim1).HasColumnName("b_MResim1");

            // Relationships
            this.HasOptional(t => t.Makale)
                .WithMany(t => t.Blog_Makales)
                .HasForeignKey(d => d.b_MMKategoryID);
            this.HasOptional(t => t.MakaleTur)
                .WithMany(t => t.Blog_Makales)
                .HasForeignKey(d => d.b_MTur);

        }
    }
}
