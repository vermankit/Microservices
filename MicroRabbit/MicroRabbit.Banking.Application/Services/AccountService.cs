using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Models;
using MicroRabbit.Transfer.Domain.Commands;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        private readonly IEventBus _eventBus;
        public AccountService(IAccountRepository accountRepository,IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Tranfer(AccountTransfer accountTransfer)
        {
            var createTranferCommand = new CreateTransferCommand(
                 accountTransfer.AccountFrom,
                 accountTransfer.AccountTo,
                 accountTransfer.TranferAmount               
                );

            _eventBus.SendCommand(createTranferCommand);
        }
    }
}
