using System;
using FluentNHibernate.Mapping;

namespace EventEgg.Domain.Asset
{
    public class ImageGallery : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual Guid GalleryId { get; set; }
        public virtual Guid ImageId { get; set; }
        public virtual int DisplayOrder { get; set; }

        #region Implementation of IEntity

        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }

        #endregion
    }

    public class ImageGalleryMap : ClassMap<ImageGallery>
    {
        public ImageGalleryMap()
        {
            Schema("Asset");
            Table("ImageGallery");

            Id(p => p.Id);
            Map(p => p.GalleryId);
            Map(p => p.ImageId);
            Map(p => p.DisplayOrder);
            Map(p => p.CreatedDate);
            Map(p => p.LastModifiedDate);
        }
    }
}
