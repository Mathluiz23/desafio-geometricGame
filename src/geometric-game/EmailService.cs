// CRIAR MÉTODO PARA ENVIAR EMAIL COM attachmentFile E RETORNAR O STATUS DO ENVIO (SUCESSO OU FALHA)

using System.Net.Mail;

namespace diamond_game;

public class EmailService
{
  public static bool EnviarEmail(string emailRecipient, string subject, string message, string attachmentFile)
  {
    if (string.IsNullOrEmpty(emailRecipient))
    {
      return false;
    }

    if (string.IsNullOrEmpty(attachmentFile))
    {
      MailMessage mail = new();
      SmtpClient SmtpServer = new("smtp.office365.com");

      mail.From = new MailAddress("matheus_luizs@hotmail.com");

      mail.To.Add(emailRecipient);

      mail.Subject = subject;

      mail.Body = message;

      SmtpServer.Port = 587;
      SmtpServer.Credentials = new System.Net.NetworkCredential("INSERIR SEU EMAIL AQUI", "INSERIR SUA SENHA AQUI");
      SmtpServer.EnableSsl = true;
      SmtpServer.Timeout = 10000;

      SmtpServer.Send(mail);

      return true;
    }

    try
    {
      MailMessage mail = new();
      SmtpClient SmtpServer = new("smtp.office365.com");

      mail.From = new MailAddress("matheus_luizs@hotmail.com");

      mail.To.Add(emailRecipient);

      mail.Subject = subject;

      mail.Body = message;

      Attachment attachment;
      attachment = new Attachment(attachmentFile);
      mail.Attachments.Add(attachment);

      SmtpServer.Port = 587;
      SmtpServer.Credentials = new System.Net.NetworkCredential("INSERIR SEU EMAIL AQUI", "INSERIR SUA SENHA AQUI");
      SmtpServer.EnableSsl = true;
      SmtpServer.Timeout = 10000;

      SmtpServer.Send(mail);

      return true;
    }
    catch (Exception)
    {
      return false;
    }
  }
}
