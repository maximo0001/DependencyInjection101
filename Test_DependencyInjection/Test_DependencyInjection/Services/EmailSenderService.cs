﻿namespace Test_DependencyInjection.Services
{
    public interface IEmailSenderService
    {
        void SendEmail(string email);
    }
    public class EmailSenderService : IEmailSenderService
    {
        public void SendEmail(string email)
        {
            //TODO
            //throw new NotImplementedException();
        }
    }
}
