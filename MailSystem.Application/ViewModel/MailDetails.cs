using System;
using System.Collections.Generic;
using System.Text;
using Framework.Core;

namespace MailSystem.Application.ViewModel
{
    public class MailDetails : IViewModel
    {
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
