using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace CadetSystem
{
    public class EmailSender
    {


        public static void SendEmail(string subject, string body, string[] recipients)
        {
            try
            {

                MailMessage eMsg = new MailMessage();
                SmtpClient smtpC = new SmtpClient();

                foreach (string recipient in recipients)
                {
                    eMsg.To.Add(new MailAddress(recipient));
                }

                eMsg.From = new MailAddress("kducadetsystem@gmail.com", "KDU Cadet Management System");
                eMsg.Subject = subject;
                eMsg.Body = body;


                smtpC.Host = "smtp.gmail.com";
                smtpC.Port = 587;
                smtpC.Credentials = new System.Net.NetworkCredential("kducadetsystem@gmail.com", "kducms123");
                smtpC.EnableSsl = true;
                smtpC.Timeout = 60000;
                smtpC.Send(eMsg);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
