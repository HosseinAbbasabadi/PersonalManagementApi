using System;
using System.Collections.Generic;
using System.Text;
using MailSystem.Application.Command;

namespace MailSystem.Application
{
    public interface IMailApplication
    {
        void Compose(ComposeMail command);
    }
}
