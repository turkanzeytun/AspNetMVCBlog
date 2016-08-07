using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Models.Mapping
{
    public class SubjectMap : EntityTypeConfiguration<Subject>
    {
        public SubjectMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Subjects");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.SubjectCategoriesId).HasColumnName("SubjectCategoriesId");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            this.HasOptional(t => t.SubjectCategory)
                .WithMany(t => t.Subjects)
                .HasForeignKey(d => d.SubjectCategoriesId);

        }
    }
}
