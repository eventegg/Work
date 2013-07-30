using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Event
{
    public class City : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int CountryId { get; set; }
        public virtual string Coordinates { get; set; }
        public virtual byte Status { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        // Foreign Keys
        public virtual Country Country { get; set; }
    }

    public class CityMap : ClassMap<City>
    {
        public CityMap()
        {
            Schema("Event");
            Table("Cities");

            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.CountryId);
            Map(p => p.Coordinates);
            Map(p => p.Status);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
            References(p => p.Country).Column("CountryId");
        }
    }
}