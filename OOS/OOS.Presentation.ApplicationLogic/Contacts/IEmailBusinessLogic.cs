﻿using OOS.Domain.Contacts.Models;
using OOS.Presentation.ApplicationLogic.Contacts.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.Contacts
{
    public interface IEmailBusinessLogic
    {
        SentEmailResponse CreateFeedBack(SentEmailRequest request);

        SentEmailResponse SentEmail (SentEmailRequest request);

        List<EmailSubsribe> GetEmailSubsribe();

        List<Email> GetEmailFeedBack();

        CreateEmailSubscribeResponse CreateEmailSubscribe(CreateEmailSubscribeRequest request);

        void DeleteEmailSubsribe(string id);
    }
}
