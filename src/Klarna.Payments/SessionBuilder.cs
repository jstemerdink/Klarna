﻿using EPiServer.Commerce.Order;
using Klarna.Payments.Models;

namespace Klarna.Payments
{
    public abstract class SessionBuilder
    {
        public abstract Session Build(Session session, ICart cart, Configuration configuration, bool includePersonalInformation = false);
    }
}
