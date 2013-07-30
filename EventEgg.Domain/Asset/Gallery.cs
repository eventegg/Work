using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Asset
{
    public class Gallery : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int TableNameId { get; set; }
        public virtual int TableNameRowId { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

    }

    public class GalleryMap : ClassMap<Gallery>
    {
        public GalleryMap()
        {
            Schema("Asset");
            Table("Gallery");

            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.TableNameId);
            Map(p => p.TableNameRowId);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);

        }
    }
}
