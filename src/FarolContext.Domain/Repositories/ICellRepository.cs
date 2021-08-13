using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Repositories
{
    public interface ICellRepository
    {
        void Create(Cell cell);
        void Update(Cell cell);
    }
}