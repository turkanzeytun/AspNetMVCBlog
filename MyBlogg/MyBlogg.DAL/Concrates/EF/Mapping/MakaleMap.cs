using MyBlogg.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Concrates.EF.Mapping
{
    public class MakaleMap : EntityTypeConfiguration<Makale>
    {
        public MakaleMap()
        {
            // Primary Key
            this.HasKey(t => t.m_ID);

            // Properties
            this.Property(t => t.m_Baslik)
                .HasMaxLength(50);

            this.Property(t => t.m_Aciklama)
                .HasMaxLength(50);

            this.Property(t => t.m_BaslikResim)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Makales");
            this.Property(t => t.m_ID).HasColumnName("m_ID");
            this.Property(t => t.m_Baslik).HasColumnName("m_Baslik");
            this.Property(t => t.m_Aciklama).HasColumnName("m_Aciklama");
            this.Property(t => t.m_AktiMi).HasColumnName("m_AktiMi");
            this.Property(t => t.m_BaslikResim).HasColumnName("m_BaslikResim");
            this.Property(t => t.m_UstmKategori).HasColumnName("m_UstmKategori");
            this.Property(t => t.m_AnaKategori).HasColumnName("m_AnaKategori");

            // Relationships
            this.HasOptional(t => t.MakaleKategori)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.m_AnaKategori);
            this.HasOptional(t => t.Makale1)
                .WithMany(t => t.Makales1)
                .HasForeignKey(d => d.m_UstmKategori);

        }
    }
}
