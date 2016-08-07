using MyBlogg.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Concrates.EF.Mapping
{
    public class MakaleYorumlarMap : EntityTypeConfiguration<MakaleYorumlar>
    {
        public MakaleYorumlarMap()
        {
            // Primary Key
            this.HasKey(t => t.y_ID);

            // Properties
            this.Property(t => t.y_Icerik)
                .IsFixedLength()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("MakaleYorumlars");
            this.Property(t => t.y_ID).HasColumnName("y_ID");
            this.Property(t => t.y_Kullanici).HasColumnName("y_Kullanici");
            this.Property(t => t.y_Tarih).HasColumnName("y_Tarih");
            this.Property(t => t.y_AktifMi).HasColumnName("y_AktifMi");
            this.Property(t => t.y_Icerik).HasColumnName("y_Icerik");
            this.Property(t => t.b_MakaleID).HasColumnName("b_MakaleID");

            // Relationships
            this.HasOptional(t => t.YorumAtanBilgiler)
                .WithMany(t => t.MakaleYorumlars)
                .HasForeignKey(d => d.y_Kullanici);
            this.HasOptional(t => t.Blog_Makale)
               .WithMany(t => t.MakaleYorumlars)
               .HasForeignKey(d => d.b_MakaleID);

        }
    }
}
