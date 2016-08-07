using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogg.DAL.Abstracts
{
    public interface IMailProcessDAL
    {
        void SendMail(string senderAdress, string subject, string content);
    }
}
