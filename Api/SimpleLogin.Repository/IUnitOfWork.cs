namespace SimpleLogin.Repository
{
    public interface IUnitOfWork
    {
        ISampleRepository Samples { get; }
    }
}
