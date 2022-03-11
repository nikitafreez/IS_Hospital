using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class Cabinet : ModelAbstract
    {
        public Cabinet()
        {
        }

        [JsonProperty("IdCabinet")]
        public override int Id { get; set; }
        public string CabinetNum { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Cabinets";
    }
}
