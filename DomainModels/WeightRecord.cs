using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WeightTracker.DomainModels
{
    [DataContract]
    public class WeightRecord
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

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