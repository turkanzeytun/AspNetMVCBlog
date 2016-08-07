using System;
using System.Collections.Generic;

namespace MyBlogg.Model
{
    public partial class MakaleTur
    {
        public MakaleTur()
        {
            this.Blog_Makales = new List<Blog_Makale>();
        }

        public int mt_ID { get; set; }
        public string mt_Adi { get; set; }
        public virtual ICollection<Blog_Makale> Blog_Makales { get; set; }
    }
}
