using Newtonsoft.Json;

namespace IS_Hospital_Admin.Models
{
    public class Client : ModelAbstract
    {
        public Client()
        {
        }
        
        [JsonProperty("IdClient")]
        public override int Id { get; set; }

        public int IdPassport { get; set; }
        public string ClientOms { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientInn { get; set; }
        public string ClientSnils { get; set; }

        [JsonIgnore] public override string Path { get; set; } = "Clients";
    }
}