using System;
using System.Collections.Generic;

namespace MyBlogg.DAL.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Nullable<int> ArticlesId { get; set; }
        public string Comment1 { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string IpAdress { get; set; }
        public virtual Article Article { get; set; }
    }
}
