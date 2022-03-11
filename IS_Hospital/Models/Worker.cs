using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class Worker : ModelAbstract
        , INotifyPropertyChanged
    {
        public Worker()
        {
            Task.Run(async () =>
            {
                PosName = (await new Position() { Id = IdPosition }.Get()).PositionName;
                PassName = (await new Passport() { Id = IdPassport }.Get()).PassportFirstName;
                PassSecondName = (await new Passport() { Id = IdPassport }.Get()).PassportSecondName;
                PassMiddleName = (await new Passport() { Id = IdPassport }.Get()).PassportMiddleName;
            });
        }

        public string PassName;
        public string PassSecondName;
        public string PassMiddleName;
        private string _posName;

        [JsonProperty("IdWorker")]
        public override int Id { get; set; }

        public int IdPassport { get; set; }
        public int IdPosition { get; set; }

        [JsonIgnore]
        public string PosName
        {
            get => _posName; set
            {
                _posName = value;
                OnPropertyChanged();
            }
        }

        public string WorkerInn { get; set; }
        public string WorkerSnils { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerEducation { get; set; }
        public string WorkerEducationPlace { get; set; }

        [JsonIgnore]
        public override string Path { get; set; } = "Workers";

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