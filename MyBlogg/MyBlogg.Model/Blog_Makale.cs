using System;
using System.Collections.Generic;

namespace MyBlogg.Model
{
    public partial class Blog_Makale
    {
        public Blog_Makale()
        {
            this.MakaleYorumlars = new List<MakaleYorumlar>();
        }
        public int b_MakaleID { get; set; }
        public string b_MBaslik { get; set; }
        public string b_MIcerik { get; set; }
        public Nullable<int> b_MMKategoryID { get; set; }
        public Nullable<int> b_MTur { get; set; }
        public virtual Makale Makale { get; set; }
        public virtual MakaleTur MakaleTur { get; set; }
        public string b_MResim1 { get; set; }
        public virtual ICollection<MakaleYorumlar> MakaleYorumlars { get; set; }
    }
}
