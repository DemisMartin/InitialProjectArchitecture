﻿namespace AG.PaymentApp.Domain.Entity.Payments
{
    using System;
    using AG.PaymentApp.Domain.Core.ValueObject;
    using AG.PaymentApp.Domain.Entity.Bases;

    public class Payment : Entity
    {
        public Payment()
        { }

        public Payment(Guid paymentID, Guid shopperID, Guid merchantID, CreditCardProtected creditCard, Money amount)
        {
            this.Id = paymentID;
            this.ShopperID = shopperID;
            this.MerchantID = merchantID;
            this.CreditCard = creditCard;
            this.Amount = amount;
        }

        public Guid ShopperID { get; set; }
        public Guid MerchantID { get; set; }
        public Guid TransactionID { get; set; }
        public Money Amount { get; set; }
        public CreditCardProtected CreditCard { get; set; }
        public string Reference { get; set; }
        public Payment LastPaymentReceived { get; private set; } = default(Payment);

        public void AddLastPaymentReceived(Payment lastPayment)
        {
            LastPaymentReceived = lastPayment;
        }
    }
}
