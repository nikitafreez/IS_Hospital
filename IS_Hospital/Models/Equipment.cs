using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class Equipment : ModelAbstract
    {
        public Equipment()
        {
        }

        [JsonProperty("IdEquipment")]
        public override int Id { get; set; }
        public string EquipmentName { get; set; }
        public DateTime? EquipmentStartupDate { get; set; }
        public double? EquipmentServiceLife { get; set; }
        public double EquipmentCost { get; set; }
        [JsonIgnore] public override string Path { get; set; } = "Equipments";

    }
}
