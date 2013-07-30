using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using NUnit.Framework;

namespace EventEgg.Domain.Asset
{
    public class Article : IEntity
    {

        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string MainKeywords { get; set; }
        public virtual string OtherKeywords { get; set; }
        public virtual int TableNameId { get; set; }
        public virtual int TableNameRowId { get; set; }
        public virtual byte Status { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }


        public virtual IList<ArticleContent> Contents { get; set; }

        public Article()
        {
            Contents = new List<ArticleContent>();
        }
    }
    [TestFixture]
    public class ArticleMap : ClassMap<Article>
    {

        public ArticleMap()
        {
            Schema("Asset");
            Table("Articles");

            Id(p => p.Id);
            Map(p => p.Title);
            Map(p => p.MainKeywords);
            Map(p => p.OtherKeywords);
            Map(p => p.TableNameId);
            Map(p => p.TableNameRowId);
            Map(p => p.Status);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);

            HasMany(p => p.Contents).KeyColumn("ArticleId").LazyLoad();
        }
    }
}
