using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogg.DAL.Concrates.EF.GenericRepositoryPattern.Units
{
    public interface IBasicProcessUnit : IDisposable
    {
        void Save();
        // Başka operasyonlar da tanımlanabilir. 
        // void OpenTransaction(); 
        // void CloseTransaction(); 
        // gibi 
    }
}
