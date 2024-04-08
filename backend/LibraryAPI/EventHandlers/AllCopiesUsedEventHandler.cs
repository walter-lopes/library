using LibraryAPI.Domain;

namespace LibraryAPI.EventHandlers;

public class AllCopiesUsedEventHandler : IEventHandler<AllCopiesUsedEvent>
{
    public Task Handle(AllCopiesUsedEvent @event)
    {
        //Send to queue, consumer can send an alert
        return Task.CompletedTask;
    }
}