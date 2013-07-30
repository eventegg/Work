using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Asset
{
    public class Template : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string ScreenShot { get; set; }
        public virtual byte Status { get; set; }
        public virtual string Path { get; set; }
        public virtual string Provider { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
    }

    public class TemplateMap : ClassMap<Template>
    {
        public TemplateMap()
        {
            Id(p => p.Id);
            Map(p => p.Name);
            Map(p => p.CategoryId);
            Map(p => p.ScreenShot);
            Map(p => p.Status);
            Map(p => p.Path);
            Map(p => p.Provider);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
        }
    }
}
