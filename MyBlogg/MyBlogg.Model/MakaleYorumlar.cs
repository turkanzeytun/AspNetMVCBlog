using System;
using System.Collections.Generic;

namespace MyBlogg.Model
{
    public partial class MakaleYorumlar
    {
        public int y_ID { get; set; }
        public Nullable<int> y_Kullanici { get; set; }
        public Nullable<DateTime> y_Tarih { get; set; }
        public bool y_AktifMi { get; set; }
        public string y_Icerik { get; set; }
        public Nullable<int> b_MakaleID { get; set; }
        
        public virtual YorumAtanBilgiler YorumAtanBilgiler { get; set; }
        public virtual Blog_Makale Blog_Makale { get; set; }
    }
}
