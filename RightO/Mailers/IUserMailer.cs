using Mvc.Mailer;
using RightO.Models;

namespace RightO.Mailers
{ 
    public interface IUserMailer
    {
			MvcMailMessage Welcome(string subject, string toAddress, ContactModel contactModel);
			MvcMailMessage PasswordReset();
	}
}