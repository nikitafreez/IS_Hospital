using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class Accounting : ModelAbstract
    {
        public Accounting()
        {
        }

        [JsonProperty("IdAccounting")]
        public override int Id { get; set; }
        public double BudgetAmmount { get; set; }
        [JsonIgnore] public override string Path { get; set; } = "Accountings";
    }
}