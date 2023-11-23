namespace DemoSolid.ISP
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll(Guid id);
        T GetById(Guid id);
    }
}
