using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class WorkersOnCabinet : ModelAbstract
    {
        public WorkersOnCabinet()
        {
        }

        [JsonProperty("IdWorkersOnCabinets")]
        public override int Id { get; set; }
        public int IdWorker { get; set; }
        public int IdCabinet { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "WorkersOnCabinets";
    }
}
