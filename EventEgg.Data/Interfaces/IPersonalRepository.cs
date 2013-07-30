using EventEgg.Domain.Personal;

namespace EventEgg.Data.Interfaces
{
    public interface IPersonalRepository : IRepository<PersonalDetail>
    {
        bool IsAuthenticate(string email, string password);
    }
}