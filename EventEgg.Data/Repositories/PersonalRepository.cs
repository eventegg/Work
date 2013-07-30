using EventEgg.Data.Interfaces;
using EventEgg.Domain.Personal;

namespace EventEgg.Data.Repositories
{
    public class PersonalRepository : RepositoryBase<PersonalDetail>, IPersonalRepository
    {
        public bool IsAuthenticate(string email, string password)
        {
            return (this.Count(p => p.Email == email && p.Password == password) > 0);
        }

        public string GetRole(string email)
        {
            return (this.SingleBy(p => p.Email == email)).Role.Name;
        }
    }
}
