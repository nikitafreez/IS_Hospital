using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class EquipmentsOnCabinet : ModelAbstract
    {
        public EquipmentsOnCabinet()
        {
        }

        [JsonProperty("IdEquipmentsOnCabinet")]
        public override int Id { get; set; }
        public int IdEquipment { get; set; }
        public int IdCabinet { get; set; }
        public int EquipmentNum { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "EquipmentsOnCabinets";
    }
}
