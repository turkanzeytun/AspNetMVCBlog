using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.TitleImage)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Articles");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SubjectsId).HasColumnName("SubjectsId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ContentText).HasColumnName("ContentText");
            this.Property(t => t.TitleImage).HasColumnName("TitleImage");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");

            // Relationships
            this.HasOptional(t => t.Subject)
                .WithMany(t => t.Articles)
                .HasForeignKey(d => d.SubjectsId);

        }
    }
}
