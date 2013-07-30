using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using NUnit.Framework;

namespace EventEgg.Domain.Event
{
    public class Country : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual byte Status { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        // Foreign Keys
        public virtual IList<City> Cities { get; set; }


        public Country()
        {
            Cities = new List<City>();
        }
    }

    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {

            Schema("Event");
            Table("Countries");

            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.Status);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
            HasMany(p => p.Cities).KeyColumn("CountryId");
        }
    }
}
