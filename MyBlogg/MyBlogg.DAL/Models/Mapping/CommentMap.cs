using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserId)
                .HasMaxLength(50);

            this.Property(t => t.IpAdress)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Comments");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ArticlesId).HasColumnName("ArticlesId");
            this.Property(t => t.Comment1).HasColumnName("Comment");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IpAdress).HasColumnName("IpAdress");

            // Relationships
            this.HasOptional(t => t.Article)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.ArticlesId);

        }
    }
}
