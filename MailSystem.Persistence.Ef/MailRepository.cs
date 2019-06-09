using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MailSystem.Domain;

namespace MailSystem.Persistence.Ef
{
    public class MailRepository : IMailRepository
    {
        private List<Mail> mails = new List<Mail>()
        {
            new Mail
            {
                Id = 1,
                Subject = "fds",
                Message = "fdsafds",
                Sender = "command.Sender",
                Receiver = "command.Receiver",
                HasAttachments = false,
                IsDeleted = false,
                IsRead = false,
                SendDate = DateTime.Now
            }
        };

        public void Create(Mail entity)
        {
            this.mails.Add(entity);
        }

        public List<Mail> GetAll()
        {
            return mails;
        }

        public Mail Get(Expression expression)
        {
            throw new NotImplementedException();
        }

        public Mail GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Mail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(long id, Mail entity)
        {
            throw new NotImplementedException();
        }
    }
}
