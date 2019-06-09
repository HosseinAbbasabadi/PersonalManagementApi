using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MailSystem.Domain;

namespace MailSystem.Persistence.Ef
{
    public class MailRepository : IMailRepository
    {
        public void Create(Mail entity)
        {
            throw new NotImplementedException();
        }

        public List<Mail> GetAll()
        {
            throw new NotImplementedException();
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
