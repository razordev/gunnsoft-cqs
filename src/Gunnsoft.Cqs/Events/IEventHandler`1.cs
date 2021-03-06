﻿using System.Threading;
using System.Threading.Tasks;

namespace Gunnsoft.Cqs.Events
{
    public interface IEventHandler<in TEvent>
        where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event, CancellationToken cancellationToken);
    }
}