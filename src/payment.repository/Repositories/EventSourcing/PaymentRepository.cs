﻿namespace AG.PaymentApp.repository.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AG.PaymentApp.Domain.Commands.Payments;
    using AG.PaymentApp.Domain.events;
    using AG.PaymentApp.Domain.queries.Interface;
    using AG.PaymentApp.Domain.Query.Payments;
    using AG.PaymentApp.repository.commands.Interface;

    public class PaymentRepository : IPaymentEventRepository, IFindPaymentEventRepository
    {
        public void Add(PaymentCommand obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<PaymentCommand> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentMongo>> GetAllAsync(FindPaymentQuery findPaymentQuery)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMongo> GetAsync(Guid PaymentID)
        {
            throw new NotImplementedException();
        }

        public PaymentCommand GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentMongo> GetLastPaymentReceivedAsync(FindPaymentQuery findPaymentQuery)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(PaymentCommand eventData)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(PaymentCommand obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PaymentCommand eventData)
        {
            throw new NotImplementedException();
        }
    }
    //{
    //    private readonly IEventPaymentRepositoryStartup eventPaymentRepositoryStartup;
    //    private readonly IMongoCollection<PaymentMongo> paymentEvents;

    //    public PaymentRepository(IEventPaymentRepositoryStartup eventPaymentRepositoryStartup)
    //    {
    //        this.eventPaymentRepositoryStartup = eventPaymentRepositoryStartup;
    //        this.paymentEvents = this.GetPaymentCollection();
    //    }
    //    public async Task SaveAsync(PaymentCommand paymentDataCommand)
    //    {
    //        paymentDataCommand.PaymentMongo.DateCreated = DateTime.Now;
    //        await this.paymentEvents.InsertOneAsync(paymentDataCommand.PaymentMongo).ConfigureAwait(false);
    //    }

    //    public async Task UpdateAsync(PaymentCommand paymentDataCommand)
    //    {
    //        var options = new FindOneAndReplaceOptions<PaymentMongo>
    //        {
    //            IsUpsert = true
    //        };

    //        var paymentFilter = EventFiltersDefinition<PaymentMongo>.ApplyPaymentIDFilter(paymentDataCommand.PaymentMongo.PaymentID);

    //        paymentDataCommand.PaymentMongo.DateModified = DateTime.Now;
    //        await this.paymentEvents.FindOneAndReplaceAsync(paymentFilter, paymentDataCommand.PaymentMongo, options).ConfigureAwait(false);
    //    }

    //    public async Task<PaymentMongo> GetLastPaymentReceivedAsync(FindPaymentQuery findPaymentQuery)
    //    {
    //        return (await GetAllAsync(findPaymentQuery)).FirstOrDefault<PaymentMongo>();
    //    }

    //    public async Task<PaymentMongo> GetAsync(Guid paymentID)
    //    {
    //        var findPaymentQuery = new FindPaymentQuery(paymentID);
    //        return (await GetAllAsync(findPaymentQuery)).FirstOrDefault<PaymentMongo>();
    //    }

    //    public async Task<IEnumerable<PaymentMongo>> GetAllAsync(FindPaymentQuery findPaymentQuery)
    //    {
    //        var paymentFilter = EventFiltersDefinition<PaymentMongo>.ApplyPaymentIDFilter(findPaymentQuery.PaymentID);

    //        var merchantFilter = EventFiltersDefinition<PaymentMongo>.ApplyMerchantIDFilter(findPaymentQuery.MerchantID);

    //        var shopperFilter = EventFiltersDefinition<PaymentMongo>.ApplyShooperIDFilter(findPaymentQuery.ShopperID);

    //        var options = new FindOptions<PaymentMongo>
    //        {
    //            Sort = Builders<PaymentMongo>.Sort.Descending(p => p.DateCreated)
    //        };

    //        var payments = await this.paymentEvents
    //            .FindAsync(paymentFilter & merchantFilter & shopperFilter, options)
    //            .Result.ToListAsync()
    //            .ConfigureAwait(false);

    //        return payments;
    //    }

    //    private IMongoCollection<PaymentMongo> GetPaymentCollection()
    //    {
    //        return this.eventPaymentRepositoryStartup.GetMongoCollection();
    //    }
    //}

}
