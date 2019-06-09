using System;
using System.Collections.Generic;
using System.Text;
using MailSystem.Application.Command;
using MailSystem.Application.ViewModel;

namespace MailSystem.Application
{
    public interface IMailApplication
    {
        void Compose(ComposeMail command);
        List<MailDetails> GetAllMails();
    }
}
