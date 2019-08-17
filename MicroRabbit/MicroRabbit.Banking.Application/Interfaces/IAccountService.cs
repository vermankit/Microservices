using MicroRabbit.Transfer.Application.Models;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Tranfer(AccountTransfer accountTransfer);

    }
}
