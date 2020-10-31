using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbVirtualCash
{
    public partial class Administrator : Form
    {
        private DataSendMailConfirmation _dataSendMailConfirmation;
        public Administrator()
        {
            InitializeComponent();
            _dataSendMailConfirmation = new DataSendMailConfirmation();
        }

        #region Metodos
        private void SendConfirmationEmail()
        {
            MailMessage _mailMessage = new MailMessage();
            _mailMessage.To.Add("esteban.pallero@gmail.com");
            _mailMessage.Subject = "Prueba";
            _mailMessage.SubjectEncoding = Encoding.UTF8;

            _mailMessage.Body = "Mensaje de prueba";
            _mailMessage.BodyEncoding = Encoding.UTF8;

            _mailMessage.IsBodyHtml = true;
            _mailMessage.From = new MailAddress("estebanjoelpallero@hotmail.com");
            SmtpClient cliente = new SmtpClient();

            //credenciales del correo emisor.
            cliente.Credentials = new NetworkCredential("hotmail.com", "clave");

            //si es a un gmail se pueden agregar las siguientes características:

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.office365.com";

            _dataSendMailConfirmation.SendMailConfirmation(cliente, _mailMessage);

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            SendConfirmationEmail();
        }
    }
}
