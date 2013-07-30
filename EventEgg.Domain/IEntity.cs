using System;

namespace EventEgg.Domain
{
    public interface IEntity
    {
        DateTime CreatedDate { get; set; }
        DateTime LastModifiedDate { get; set; }
    }
}