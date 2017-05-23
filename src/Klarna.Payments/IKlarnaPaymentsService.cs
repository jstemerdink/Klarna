﻿using System.Threading.Tasks;
using EPiServer.Commerce.Order;
using Klarna.Common;
using Klarna.Common.Models;
using Klarna.Payments.Models;

namespace Klarna.Payments
{
    public interface IKlarnaPaymentsService : IKlarnaService
    {
        Task<bool> CreateOrUpdateSession(ICart cart);
        string GetClientToken(ICart cart);
        Task<Session> GetSession(ICart cart);
        void CompleteAndRedirect(IPurchaseOrder purchaseOrder);
        Task CancelAuthorization(string authorizationToken);
        Task<CreateOrderResponse> CreateOrder(string authorizationToken, ICart cart);
        bool CanSendPersonalInformation(string countryCode);
        bool AllowedToSharePersonalInformation(ICart cart);
        bool AllowSharingOfPersonalInformation(ICart cart);
        PersonalInformationSession GetPersonalInformationSession(ICart cart);
    }
}