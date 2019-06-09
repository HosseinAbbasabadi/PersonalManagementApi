using MailSystem.Application.Command;
using MailSystem.Domain;

namespace MailSystem.Application
{
    public class MailApplication : IMailApplication
    {
        private readonly IMailRepository _mailRepository;

        public MailApplication(IMailRepository mailRepository)
        {
            _mailRepository = mailRepository;
        }

        public void Compose(ComposeMail command)
        {
            throw new System.NotImplementedException();
        }
    }
}