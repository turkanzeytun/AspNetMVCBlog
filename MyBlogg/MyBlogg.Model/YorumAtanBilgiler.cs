using System;
using System.Collections.Generic;

namespace MyBlogg.Model
{
    public partial class YorumAtanBilgiler
    {
        public YorumAtanBilgiler()
        {
            this.MakaleYorumlars = new List<MakaleYorumlar>();
        }

        public int k_ID { get; set; }
        public string k_IPAdres { get; set; }
        public bool k_EngelliMi { get; set; }
        public Nullable<DateTime> k_Tarih { get; set; }
        public virtual ICollection<MakaleYorumlar> MakaleYorumlars { get; set; }
    }
}
