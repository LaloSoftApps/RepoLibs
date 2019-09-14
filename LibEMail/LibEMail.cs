using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace LibEMail
{
    public class EMail
    {
        public static string From { get; set; }
        public static string ServerSmtp { get; set; }
        public static int ServerPort { get; set; }
        public static string LoginUsr { get; set; }
        public static string LoginUsrPwd { get; set; }
        public static string Subject { get; set; }
        public static string Boby { get; set; }
        public static string AttachFiles { get; set; }
        
        public static bool Send(string To)
        {
            try {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(ServerSmtp);

                mail.From = new MailAddress(From + "<" + LoginUsr + ">");
                mail.To.Add(To);
                mail.Subject = Subject;
                mail.Body = Boby;
                mail.IsBodyHtml = true;
                // Only File
                // mail.Attachments.Add(new Attachment(AttachFiles));
                
                // Split Files by coma
                foreach (String FileToAttach in AttachFiles.Split(',') )
                {
                    mail.Attachments.Add(new Attachment(FileToAttach));
                }
                

                SmtpServer.Port = ServerPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(LoginUsr, LoginUsrPwd);
                // SmtpServer.EnableSsl = true;
                
                SmtpServer.Send(mail);

                return true;
            } catch (Exception ex) {
                return false;
            }

        }
    }
}
