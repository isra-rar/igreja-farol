using FarolContext.Domain.Entities;

namespace FarolContext.Domain.Repositories
{
    public interface IMemberRepository
    {
        void Create(Member member);
        void Update(Member member);
    }
}