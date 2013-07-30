using System;
using FluentNHibernate.Mapping;


namespace EventEgg.Domain.Asset
{
    public class Video : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Path { get; set; }
        public virtual int TableNameId { get; set; }
        public virtual int TableNameRowId { get; set; }
        public virtual byte Status { get; set; }
        public virtual string Provider { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
    }

    public class VideoMap:ClassMap<Video>
    {
        public VideoMap()
        {
            Schema("Asset");
            Table("Videos");

            Id(p => p.Id).Not.Not.GeneratedBy.GuidComb();

            Map(p => p.Name);
            Map(p => p.Path);
            Map(p => p.TableNameId);
            Map(p => p.TableNameRowId);
            Map(p => p.Status);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
        }
    }
}
