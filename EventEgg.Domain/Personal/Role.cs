using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;

namespace EventEgg.Domain.Personal
{
    public class Role
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        public virtual IList<PersonalDetail> PersonalDetails { get; set; }

        public Role()
        {
            PersonalDetails = new List<PersonalDetail>();
        }

    }

    public class RolesMap : ClassMap<Role>
    {
        public RolesMap()
        {
            Schema("[User]");
            Table("[Roles]");
            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.LastModifiedDate);
            Map(p => p.CreatedDate);

            HasMany(p => p.PersonalDetails).KeyColumn("RoleId");
        }
    }
}