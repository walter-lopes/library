using System.Reflection.Metadata;

namespace LibraryAPI.EventHandlers;

public interface IEventHandler<T>
{
    Task Handle(T @event);
}