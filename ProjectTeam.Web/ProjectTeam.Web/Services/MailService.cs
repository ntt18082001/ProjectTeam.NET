using MailKit.Net.Smtp;
using MimeKit;
using ProjectTeam.Web.Common.Mailer;

namespace ProjectTeam.Web.Services
{
	public class MailService
	{
		private AppMailConfiguration mailConfig;
		public AppMailSender Sender { get; set; }
		public AppMailReciver Reciver { get; set; }
		public AppMailCc MailCc { get; set; }
		public MailService(AppMailConfiguration _config)
		{
			mailConfig = _config;
		}
		private bool PrivateSend()
		{
			if (this.Sender == null || this.Reciver == null || this.mailConfig == null)
			{
				throw new Exception("Không thể gửi mail với dữ liệu rỗng");
			}

			if (String.IsNullOrEmpty(Reciver.Email))
			{
				return false;
			}

			MimeMessage message = new MimeMessage();

			MailboxAddress from = new MailboxAddress(Sender.Name, mailConfig.Email);
			message.From.Add(from);

			MailboxAddress to = new MailboxAddress(Reciver.Name, Reciver.Email);
			message.To.Add(to);

			if(this.MailCc != null)
			{
				MailboxAddress mailCc = new MailboxAddress(MailCc.Name, MailCc.Email);
				message.Cc.Add(mailCc);
			}

			message.Subject = Sender.Subject;

			BodyBuilder bodyBuilder = new BodyBuilder();
			bodyBuilder.HtmlBody = Sender.Content;
			// + "\n------\n" + mailConfig.Signature
			message.Body =  bodyBuilder.ToMessageBody();
			try
			{
				SmtpClient client = new SmtpClient();
				client.Connect(mailConfig.SmtpServer, mailConfig.Port, true);
				client.Authenticate(mailConfig.Email, mailConfig.Password);
				
				client.Send(message);
				client.Disconnect(true);
				client.Dispose();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public void Send()
		{
			this.PrivateSend();
		}

		public void SendInBackground()
		{
			Thread thMail = new Thread(() =>
			{
				this.PrivateSend();
			});
			thMail.Start();
		}

		public static void SendToList(AppMailSender sender, IEnumerable<AppMailReciver> recivers, AppMailConfiguration mailConfig, AppMailCc mailCc = null)
		{
			if (sender == null || recivers == null || mailConfig == null || recivers.Count() == 0)
			{
				throw new Exception("Không thể gửi mail với dữ liệu rỗng");
			}

			try
			{
				Parallel.ForEach(recivers, (reciver) =>
				{
					MailService mailer = new MailService(mailConfig);
					mailer.Sender = sender;
					mailer.Reciver = reciver;
					if(mailCc != null)
					{
						mailer.MailCc = mailCc;
					}
					mailer.Send();
				});
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
		public static void SendToListInBackground(AppMailSender sender, IEnumerable<AppMailReciver> recivers, AppMailConfiguration mailConfig, AppMailCc mailCc = null)
		{
			Thread thMail = new Thread(() =>
			{
				SendToList(sender, recivers, mailConfig, mailCc);
			});
			thMail.Start();
		}
	}
}
