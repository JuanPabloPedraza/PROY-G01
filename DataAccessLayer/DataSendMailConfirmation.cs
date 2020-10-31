using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace DataAccessLayer
{
    public class DataSendMailConfirmation
    {
        public void SendMailConfirmation(SmtpClient cliente, MailMessage _mailMessage)
        {
            try
            {
                cliente.Send(_mailMessage);
            }
            catch (Exception e)
            {
                throw new Exception("Error al enviar mail de confirmación", e);
            }
        }
    }
}