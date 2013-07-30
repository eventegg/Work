using System;
using EventEgg.Domain.Event;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Personal
{
    public class PersonalDetail
    {
        public virtual Guid Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Password { get; set; }
        public virtual byte Gender { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Title { get; set; }
        public virtual string BioDescription { get; set; }
        public virtual byte Type { get; set; }
        public virtual string PersonalWebUrl { get; set; }
        public virtual string GooglePlus { get; set; }
        public virtual string Twitter { get; set; }
        public virtual int RoleId { get; set; }
        public virtual byte Status { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        // Foreign Keys
        public virtual int CountryId { get; set; }
        public virtual int CityId { get; set; }

        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        public virtual Role Role { get; set; }
    }

    [Serializable]
    public class PersonDetailMap : ClassMap<PersonalDetail>
    {
        public PersonDetailMap()
        {

            Schema("[User]"); // veritabanındaki şema adı
            Table("[PersonDetails]"); // veritabanındaki tablo adı

            Id(p => p.Id).Not.Nullable().GeneratedBy.Guid();
            Map(p => p.Email).Not.Nullable();
            Map(p => p.FirstName);
            Map(p => p.LastName);
            Map(p => p.Password);
            Map(p => p.Gender);
            Map(p => p.Address);
            Map(p => p.Phone);
            Map(p => p.Mobile);
            Map(p => p.Title);
            Map(p => p.BioDescription);
            Map(p => p.Type);
            Map(p => p.PersonalWebUrl);
            Map(p => p.Status);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
            Map(p => p.CityId);
            Map(p => p.CountryId);
            Map(p => p.RoleId);

            References(p => p.Role).Column("RoleId");
            References(p => p.Country).Column("CountryId");
            References(p => p.City).Column("CityId");

        }
    }
}
