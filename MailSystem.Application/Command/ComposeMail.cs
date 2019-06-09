using Framework.Core;


namespace MailSystem.Application.Command
{
    public class ComposeMail : ICommand
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
    }
}
