using SendGrid.Helpers.Mail;
using SendGrid;

namespace WebApplication1.Controllers
{
    public class GenerateOTP
    {
        public void generateOTP(string email, int otp)
        {
            string apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            Console.WriteLine(apiKey);
            if (apiKey != null)
            {
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("warmouleas@gmail.com", "Appointment Scheduler");
                var subject = "Recover your account";
                var to = new EmailAddress(email, "User");
                var plainTextContent = "";
                var htmlContent = $"OTP: {otp}<br /><strong>This is a remainder mail please do not reply</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                DateTime sendDateTime = DateTime.Now;
                msg.SendAt = new DateTimeOffset(sendDateTime).ToUnixTimeSeconds();
                var response = client.SendEmailAsync(msg).Result;
            }
        }
       
    }
}
