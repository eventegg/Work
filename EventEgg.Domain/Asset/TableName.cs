using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Asset
{
    public class TableName : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        #region Implementation of IEntity

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        #endregion
    }

    public class TableNameMap : ClassMap<TableName>
    {
        public TableNameMap()
        {
            Schema("Asset");
            Table("TableName");

            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
        }
    }
}
