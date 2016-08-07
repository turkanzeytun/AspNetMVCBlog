using MyBlogg.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Concrates.EF.Mapping
{
    public class MakaleTurMap : EntityTypeConfiguration<MakaleTur>
    {
        public MakaleTurMap()
        {
            // Primary Key
            this.HasKey(t => t.mt_ID);

            // Properties
            this.Property(t => t.mt_Adi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MakaleTurs");
            this.Property(t => t.mt_ID).HasColumnName("mt_ID");
            this.Property(t => t.mt_Adi).HasColumnName("mt_Adi");
        }
    }
}
