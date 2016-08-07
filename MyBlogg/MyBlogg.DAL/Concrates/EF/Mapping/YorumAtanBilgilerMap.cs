using MyBlogg.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyBlogg.DAL.Concrates.EF.Mapping
{
    public class YorumAtanBilgilerMap : EntityTypeConfiguration<YorumAtanBilgiler>
    {
        public YorumAtanBilgilerMap()
        {
            // Primary Key
            this.HasKey(t => t.k_ID);

            // Properties
            this.Property(t => t.k_IPAdres)
                .IsFixedLength()
                .HasMaxLength(15);


            // Table & Column Mappings
            this.ToTable("YorumAtanBilgilers");
            this.Property(t => t.k_ID).HasColumnName("k_ID");
            this.Property(t => t.k_IPAdres).HasColumnName("k_IPAdres");
            this.Property(t => t.k_EngelliMi).HasColumnName("k_EngelliMi");
            this.Property(t => t.k_Tarih).HasColumnName("k_Tarih");
        }
    }
}
