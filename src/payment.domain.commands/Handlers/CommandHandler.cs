﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandHandler.cs" company="AG Software">
//   Copyright (c) AG. All rights reserved.
// </copyright>
// <summary>
// CommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AG.PaymentApp.Domain.Core.Notifications;
using MediatR;
using Payment.Domain.Core.Bus;
using Payment.Domain.Core.Commands;
using Payment.Domain.Interface;

namespace Payment.Domain.Commands.Handlers
{
    public class CommandHandler
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediatorHandler mediatorHandler;
        private readonly DomainNotificationHandler notifications;

        public CommandHandler(IUnitOfWork unitOfWork, IMediatorHandler mediatorHandler, INotificationHandler<DomainNotification> notifications)
        {
            this.unitOfWork = unitOfWork;
            this.notifications = (DomainNotificationHandler)notifications;
            this.mediatorHandler = mediatorHandler;
        }

        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                mediatorHandler.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (notifications.HasNotifications())
                return false;

            if (unitOfWork.Commit())
                return true;

            mediatorHandler.RaiseEvent(new DomainNotification("Commit", "We had a problem during saving your data."));
            return false;
        }
    }
}