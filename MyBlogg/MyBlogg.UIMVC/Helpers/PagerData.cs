using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogg.UIMVC.Helpers
{
    public class PagerData<T> where T : class
    {
        public IQueryable<T> Data { get; set; }
        public int NumberOfPages { get; set; }
        public int CurrentPage { get; set; }
    }
}