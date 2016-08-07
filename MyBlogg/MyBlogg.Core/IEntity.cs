using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlogg.Core
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
