using System;

namespace MailSystem.Domain
{
    public class Mail
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRead { get; set; }
        public bool HasAttachments { get; set; }

        //public void CheckSomething(string sender, string reciver)
        //{
        //    // some checks
        //}
    }
}
