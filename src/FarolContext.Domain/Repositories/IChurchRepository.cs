using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Repositories
{
    public interface IChurchRepository
    {
        void Create(Church church);
        void Update(Church church);
    }
}