/*****************************************************
 * 
 *              (c) Raphael Frei - 2022
 *          Send email using SMTP (Send Only)
 * 
 *****************************************************/

namespace RF {
    public static class SMTP {

        public static string SendEmailHTML(string sender, string receiver, string subject, string body, string SMTPClient, int priority) {

            try {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add(receiver);
                message.Subject = subject;
                message.From = new System.Net.Mail.MailAddress(sender);

                message.Priority = priority switch {
                    0 => System.Net.Mail.MailPriority.High,
                    1 => System.Net.Mail.MailPriority.Normal,
                    2 => System.Net.Mail.MailPriority.Low,
                    _ => System.Net.Mail.MailPriority.Normal,
                };

                message.Body = body;
                message.IsBodyHtml = true;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(SMTPClient);

                smtp.Send(message);

                return $"SUCCESS - Email sent to: {receiver}";

            } catch (System.Exception ex) {
                return $"ERROR - While sending email: {ex}";

            }

        }
    }
}
