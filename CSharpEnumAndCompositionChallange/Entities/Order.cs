﻿using CSharpEnumAndCompositionChallange.Entities.Enums;
using System.Globalization;
using System.Text;

namespace CSharpEnumAndCompositionChallange.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client Client { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();

        public Order()
        {
        }

        public Order(DateTime orderMoment,
            OrderStatus orderStatus,
            Client client)
        {
            Moment = orderMoment;
            Status = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
                sum += item.SubTotal();

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order Moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total Price: $" + Total().ToString("F2",
                CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}