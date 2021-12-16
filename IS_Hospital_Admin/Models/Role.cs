using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital_Admin.Models
{
    public class Role : ModelAbstract
    {
        public Role()
        {
        }

        [JsonProperty("IdRole")]
        public override int Id { get; set; }
        public string RoleName { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Roles";
    }
}
