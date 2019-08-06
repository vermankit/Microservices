using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Domain.Core.Events;
using MicroRabbit.Domain.Core.Commands;
namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscrible<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
