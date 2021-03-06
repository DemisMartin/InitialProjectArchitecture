﻿namespace AG.PaymentApp.Domain.queries.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AG.PaymentApp.Domain.Core.Enum;
    using AG.PaymentApp.Domain.Entity.Shoppers;
    using AG.PaymentApp.Domain.Query.Shoppers;

    public interface IFindShopperRepository
    {
        Task<Shopper> GetAsync(Guid shopperID);
        Task<IEnumerable<Shopper>> GetShoppersByGenderAsync(Gender gender);
        Task<IEnumerable<Shopper>> GetAllAsync(FindShopperQuery findMerchantQuery);
    }
}
