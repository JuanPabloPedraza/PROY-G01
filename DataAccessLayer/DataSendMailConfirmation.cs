using System;
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