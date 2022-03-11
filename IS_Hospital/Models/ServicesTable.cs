using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital.Models
{
    public class ServicesTables : ModelAbstract, INotifyPropertyChanged
    {
        public ServicesTables()
        {
            Task.Run(async () =>
            {
                int PassId = (await new Worker() { Id = (int)IdWorker }.Get()).IdPassport;
                WorName = (await new Passport() { Id = PassId }.Get()).PassportSecondName
                + " " + (await new Passport() { Id = PassId }.Get()).PassportFirstName
                + " " + (await new Passport() { Id = PassId }.Get()).PassportMiddleName;
            });
        }
        private string _worName;
        [JsonProperty("IdService")]
        public override int Id { get; set; }
        public string ServiceTitle { get; set; }
        public int ServiceCost { get; set; }
        public int? IdWorker { get; set; }
        [JsonIgnore]
        public string WorName
        {
            get => _worName; set
            {
                _worName = value;
                OnPropertyChanged();
            }
        }

        [JsonIgnore]
        public override string Path { get; set; } = "ServicesTables";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
