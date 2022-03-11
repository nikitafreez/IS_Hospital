using Newtonsoft.Json;

namespace IS_Hospital.Models
{
    public class User : ModelAbstract
    {
        public User()
        {
        }

        [JsonProperty("IdUser")]
        public override int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }

        [JsonIgnore] public override string Path { get; set; } = "Users";
    }
}