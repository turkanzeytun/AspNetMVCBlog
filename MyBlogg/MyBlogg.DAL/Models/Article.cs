using System;
using System.Collections.Generic;

namespace MyBlogg.DAL.Models
{
    public partial class Article
    {
        public Article()
        {
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public Nullable<int> SubjectsId { get; set; }
        public string Title { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Description { get; set; }
        public string ContentText { get; set; }
        public string TitleImage { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
