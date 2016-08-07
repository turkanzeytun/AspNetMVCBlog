using MyBlogg.DAL.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogg.BLL
{
    public class MailProcess
    {
        IMailProcessDAL mailProcessDAL;
        public MailProcess(IMailProcessDAL _mailProcessDAL)
        {
            mailProcessDAL = _mailProcessDAL;
        }
        public void SendMail(string senderAdress, string subject,  string content)
        {
            mailProcessDAL.SendMail(senderAdress, subject, content);
        }
    }
}
