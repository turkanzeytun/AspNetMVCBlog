using System;
using System.Collections.Generic;

namespace MyBlogg.Model
{
    public partial class MakaleKategori
    {
        public MakaleKategori()
        {
            this.Makales = new List<Makale>();
        }

        public int mk_ID { get; set; }
        public string mk_Adi { get; set; }
        public string mk_Aciklama { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
    }
}
