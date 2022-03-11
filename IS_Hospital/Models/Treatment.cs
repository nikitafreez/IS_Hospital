using Newtonsoft.Json;
using System;

namespace IS_Hospital.Models
{
    public class Treatment : ModelAbstract
    {
        public Treatment()
        {
        }
        
        [JsonProperty("IdTreatment")]
        public override int Id { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string TreatmentReason { get; set; }
        public double? TreatmentSum { get; set; }
        public int? IdClient { get; set; }
        [JsonIgnore] public override string Path { get; set; } = "Treatments";
    }
}