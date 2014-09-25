using System.Net.Mail;
using Mvc.Mailer;
using RightO.Models;

namespace RightO.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer 	
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}
		
		public virtual MvcMailMessage Welcome(string subject, string toAddress, ContactModel contactModel)
		{
            var mailMessage = new MvcMailMessage { Subject = subject};

            //to address will come from database
            mailMessage.To.Add(toAddress);
            ViewBag.Name = contactModel.Name;
            ViewBag.From = contactModel.Email;
            ViewBag.Comment = contactModel.Comments;
            PopulateBody(mailMessage, viewName: "Welcome");

            return mailMessage;
		}
 
		public virtual MvcMailMessage PasswordReset()
		{
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = "PasswordReset";
				x.ViewName = "PasswordReset";
				x.To.Add("some-email@example.com");
			});
		}
 	}
}