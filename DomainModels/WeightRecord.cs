using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using WeightTracker.DomainModels.Framework;

namespace WeightTracker.DomainModels
{
    [DataContract]
    public class WeightRecord : BaseEntity
    {
        [DataMember]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Weight { get; set; }

        [DataMember]
        public DateTime RecordDate { get; set; }

        [DataMember]
        public Profile Profile { get; set; }
        public Guid ProfileId { get; set; }
    }
}