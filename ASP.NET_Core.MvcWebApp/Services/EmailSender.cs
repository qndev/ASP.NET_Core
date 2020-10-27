using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using System.Threading.Tasks;
using ASP.NET_Core.MvcWebApp.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace ASP.NET_Core.MvcWebApp.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly MailKitServiceOptions _mailKitOptions;
        private readonly ILogger _logger;

        public EmailSender(
            IOptions<MailKitServiceOptions> mailKitOptions,
            ILogger<EmailSender> logger)
        {
            _mailKitOptions = mailKitOptions.Value;
            _logger = logger;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var mimeMessage = new MimeMessage ();
			mimeMessage.From.Add(new MailboxAddress(_mailKitOptions.MailName, _mailKitOptions.MailUserName));
			mimeMessage.To.Add(new MailboxAddress(email, email));
			mimeMessage.Subject = subject;
			mimeMessage.Body = new TextPart("html") {
				Text = message
			};

			using (var client = new SmtpClient()) {
				await client.ConnectAsync(_mailKitOptions.MailServer, _mailKitOptions.MailPort, false);
				await client.AuthenticateAsync(_mailKitOptions.MailUserName, _mailKitOptions.MailPassword);
				await client.SendAsync(mimeMessage);
				await client.DisconnectAsync(true);
			}
        }
    }
}
