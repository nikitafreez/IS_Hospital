using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    internal class ServicesList : ModelAbstract
    {
        public ServicesList()
        {
        }

        [JsonProperty("IdServicesLists")]
        public override int Id { get; set; }
        public int IdTreatment { get; set; }
        public int IdService { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "ServicesLists";
    }
}
