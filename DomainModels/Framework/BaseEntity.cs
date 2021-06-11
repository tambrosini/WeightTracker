using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WeightTracker.DomainModels.Framework
{
    [DataContract]
    public class BaseEntity : IEntity
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [DataMember]
        public DateTime CreateOn { get; set; } = DateTime.Now;
    }
}