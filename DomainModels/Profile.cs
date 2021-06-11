using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using WeightTracker.Data;
using WeightTracker.DomainModels.Framework;

namespace WeightTracker.DomainModels
{
    [DataContract]
    public class Profile : BaseEntity
    {
        [DataMember]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Height { get; set; }

        [DataMember]
        public int Age { get; set; }
        
        [DataMember]
        public ICollection<WeightRecord> WeightRecords { get; set; }
        
        [DataMember]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}