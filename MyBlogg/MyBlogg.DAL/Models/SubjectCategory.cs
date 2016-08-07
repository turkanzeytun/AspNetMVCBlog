using System;
using System.Collections.Generic;

namespace MyBlogg.DAL.Models
{
    public partial class SubjectCategory
    {
        public SubjectCategory()
        {
            this.Subjects = new List<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
