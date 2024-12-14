using System.Net;
using System.Net.Mail;

namespace Blog.Services;
public class EmailService
{
    public bool Send(
        string toName,
        string toEmail,
        string subject,
        string body,
        string fromName = "Blog",
        string fromEmail = "danielvafrancapt@gmail.com")
    {
        var smtpClient = new SmtpClient(Configuration.Smtp.Host, Configuration.Smtp.Port);
        smtpClient.Credentials = new NetworkCredential(Configuration.Smtp.UserName, Configuration.Smtp.Password);
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.EnableSsl = true;// porta 587

        //Menssagem De E-MAIL
        var mail = new MailMessage();

        mail.From = new MailAddress(fromEmail, fromName);
        mail.To.Add(new MailAddress(toEmail, toName));//Posso mandar par mais dfe uma pessoa
        mail.Subject = subject;
        mail.Body = body;
        mail.IsBodyHtml = true;
        try
        {
            smtpClient.Send(mail); // Enviando no try para nao quebrar a aplicação
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao enviar e-mail: {ex.Message}");
            return false;
        }
    }


}