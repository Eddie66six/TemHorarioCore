namespace TemHorario.Core.Domain
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
