using System;
using System.Collections.Generic;

namespace MyBlogg.Model
{
    public partial class Makale
    {
        public Makale()
        {
            this.Blog_Makales = new List<Blog_Makale>();
            this.Makales1 = new List<Makale>();
        }

        public int m_ID { get; set; }
        public string m_Baslik { get; set; }
        public string m_Aciklama { get; set; }
        public Nullable<bool> m_AktiMi { get; set; }
        public string m_BaslikResim { get; set; }
        public Nullable<int> m_UstmKategori { get; set; }
        public Nullable<int> m_AnaKategori { get; set; }
        public virtual ICollection<Blog_Makale> Blog_Makales { get; set; }
        public virtual MakaleKategori MakaleKategori { get; set; }
        public virtual ICollection<Makale> Makales1 { get; set; }
        public virtual Makale Makale1 { get; set; }
    }
}
