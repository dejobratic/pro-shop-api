﻿using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;
using System;

namespace ProShop.Store.App.Mappers
{
    public static class PaymentMapper
    {
        public static Payment ToDomainModel(
            this PaymentDto payment)
        {
            return new Payment(
                Enum.Parse<PaymentMethod>(payment.Method),
                payment.IsCompleted,
                payment.CompletedAt);
        }

        public static PaymentDto ToContractModel(
            this Payment payment)
        {
            return new PaymentDto
            {
                Method = payment.Method.ToString(),
                IsCompleted = payment.IsCompleted,
                CompletedAt = payment.CompletedAt
            };
        }
    }
}