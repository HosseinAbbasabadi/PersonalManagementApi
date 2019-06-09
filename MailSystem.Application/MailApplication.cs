using System;
using System.Collections.Generic;
using System.Linq;
using MailSystem.Application.Command;
using MailSystem.Application.ViewModel;
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
            var mail = new Mail
            {
                Id = 1,
                Subject = command.Subject,
                Message =  command.Message,
                Sender = command.Sender,
                Receiver = command.Receiver,
                HasAttachments = false,
                IsDeleted = false,
                IsRead = false,
                SendDate = DateTime.Now
            };
            //mail.CheckSomething(command.Sender, command.Receiver);
            _mailRepository.Create(mail);
        }

        public List<MailDetails> GetAllMails()
        {
            var mails = _mailRepository.GetAll();
            return MapMails(mails);
        }

        private static List<MailDetails> MapMails(IEnumerable<Mail> mails)
        {
            return mails.Select(MapMail).ToList();
        }
        private static MailDetails MapMail(Mail mail)
        {
            return new MailDetails
            {
                Subject   = mail.Subject,
                Message = mail.Message
            };
        }
    }
}