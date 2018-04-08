﻿using System;
using System.Collections.Generic;
using WerterStore.Domain.StoreContext.Enums;

namespace WerterStore.Domain.StoreContext.Entities
{
    public class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid()
                .ToString()
                .Replace("-", "")
                .Substring(0, 8)
                .ToUpper();
            Status = EOrderStatus.Created;
            Items = new List<OrderItem>();
            Deliveries = new List<Delivery>();

        }

        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items { get; private set; }
        public IReadOnlyCollection<Delivery> Deliveries { get; private set; }

        public void AddItem(OrderItem item)
        {
            // validar item
            // adicionar ao pedido
        }

        public void Place()
        {

        }


    }
}