namespace DemoSolid.DIP
{
    public interface IServiceBus
    {
        void Publish(string queue, Person person);
    }
}