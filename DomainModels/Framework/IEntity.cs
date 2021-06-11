using System;

namespace WeightTracker.DomainModels.Framework
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateOn { get; set; }
        //TODO: Implement the below
        // public string CreatedBy { get; set; }
        // public DateTime LastUpdated { get; set; }
        // public string LastUpdatedBy { get; set; }
    }
}