namespace DevFreela.Infrastructure.MessageBus;

public interface IMessageBusService
{
    public void Publish(string queue, byte[] message);
}
