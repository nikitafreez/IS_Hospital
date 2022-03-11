using Newtonsoft.Json;
using System;

namespace IS_Hospital.Models
{
    public class Transaction : ModelAbstract
    {
        public Transaction()
        {
        }
        
        [JsonProperty("IdTransaction")]
        public override int Id { get; set; }
        public double TransactionSum { get; set; }
        public string TransactionDescription { get; set; }
        public DateTime TransactionDate { get; set; }
        [JsonIgnore] public override string Path { get; set; } = "Transactions";
    }
}