using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Asset
{
    public class ArticleContent : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual Guid ArticleId { get; set; }
        public virtual string ContentText { get; set; }
        public virtual string HtmlType { get; set; }
        public virtual byte Status { get; set; }
        public virtual byte DisplayOrder { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        public virtual Article Article { get; set; }

    }

    public class ArticleContentMap : ClassMap<ArticleContent>
    {
        public ArticleContentMap()
        {
            Schema("Asset");
            Table("ArticleContents");

            Id(p => p.Id);
            Map(p => p.ArticleId);
            Map(p => p.ContentText);
            Map(p => p.HtmlType);
            Map(p => p.Status);
            Map(p => p.DisplayOrder);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
            References(p => p.Article).Column("ArticleId");

        }
    }
}
