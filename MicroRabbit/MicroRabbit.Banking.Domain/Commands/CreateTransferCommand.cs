using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TranferCommand
    {
        public CreateTransferCommand(int from ,int to , decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
