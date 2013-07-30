using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Asset
{
    public class AssetType : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
    }

    public class AssetTypeMap : ClassMap<AssetType>
    {
        public AssetTypeMap()
        {
            Schema("Asset");
            Table("AssetTypes");

            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
        }
    }
}
