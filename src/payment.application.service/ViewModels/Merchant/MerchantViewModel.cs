﻿namespace AG.PaymentApp.Application.Services.DTO.Merchants
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using AG.PaymentApp.Domain.Core.ValueObject;

    public class MerchantViewModel
    {
        public Guid MerchantID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Acronym { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }
        public bool IsVisible { get; set; }
        public bool IsOnline { get; set; }
    }
}
