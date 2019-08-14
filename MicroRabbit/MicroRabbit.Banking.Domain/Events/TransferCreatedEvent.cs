using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; private set; }
        public int To { get; private set; }
        public decimal Amount { get; private set; }
        public TransferCreatedEvent(int From,int To, decimal Amount)
        {
            this.From = From;
            this.To = To;
            this.Amount = Amount;
        }
    }
}
