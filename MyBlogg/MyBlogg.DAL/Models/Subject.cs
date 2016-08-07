using System;
using System.Collections.Generic;

namespace MyBlogg.DAL.Models
{
    public partial class Subject
    {
        public Subject()
        {
            this.Articles = new List<Article>();
        }

        public int Id { get; set; }
        public Nullable<int> SubjectCategoriesId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual SubjectCategory SubjectCategory { get; set; }
    }
}
