using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class Client : ModelAbstract
        , INotifyPropertyChanged
    {
        public Client()
        {
            Task.Run(async () =>
            {
                PassName = (await new Passport() { Id = IdPassport }.Get()).PassportFirstName;
                PassSecondName = (await new Passport() { Id = IdPassport }.Get()).PassportSecondName;
                PassMiddleName = (await new Passport() { Id = IdPassport }.Get()).PassportMiddleName;
            });
        }


        public string PassName;
        public string PassSecondName;
        public string PassMiddleName;

        [JsonProperty("IdClient")]
        public override int Id { get; set; }

        public int IdPassport { get; set; }
        public string ClientOms { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientInn { get; set; }
        public string ClientSnils { get; set; }

        [JsonIgnore] public override string Path { get; set; } = "Clients";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        [JsonIgnore]
        public string FIO
        {
            get { return $"{PassSecondName} {PassName} {PassMiddleName}"; }
        }
    }
}