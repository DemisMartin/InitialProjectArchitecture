﻿namespace AG.Payment.Domain.Core.Commands
{
    using System;
    using AG.PaymentApp.Domain.Core.Events;
    using FluentValidation.Results;

    public abstract class Command : Message
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
