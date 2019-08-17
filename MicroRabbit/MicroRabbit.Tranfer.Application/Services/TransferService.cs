using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        private readonly IEventBus _eventBus;
        public TransferService(ITransferRepository accountRepository,IEventBus eventBus)
        {
            _transferRepository = accountRepository;
            _eventBus = eventBus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
      
    }
}
