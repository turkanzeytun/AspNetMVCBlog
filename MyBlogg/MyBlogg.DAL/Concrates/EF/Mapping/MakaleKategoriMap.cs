using MyBlogg.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Concrates.EF.Mapping
{
    public class MakaleKategoriMap : EntityTypeConfiguration<MakaleKategori>
    {
        public MakaleKategoriMap()
        {
            // Primary Key
            this.HasKey(t => t.mk_ID);

            // Properties
            this.Property(t => t.mk_Adi)
                .HasMaxLength(50);

            this.Property(t => t.mk_Aciklama)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("MakaleKategoris");
            this.Property(t => t.mk_ID).HasColumnName("mk_ID");
            this.Property(t => t.mk_Adi).HasColumnName("mk_Adi");
            this.Property(t => t.mk_Aciklama).HasColumnName("mk_Aciklama");
        }
    }
}
