using System.Collections.Generic;
using System.Linq;
using EventEgg.Data.Interfaces;
using EventEgg.Domain.Personal;

namespace EventEgg.Data.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository()
        {
            
        }

        public IList<Role> RoleList()
        {
            return this.Query().ToList();
        }
    }
}
