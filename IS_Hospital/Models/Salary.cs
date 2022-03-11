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
    public class Salary : ModelAbstract, INotifyPropertyChanged
    {
        public Salary()
        {
            Task.Run(async () =>
            {
                WorINN = (await new Worker() { Id = IdWorker }.Get()).WorkerInn;
            });
        }

        private string _worINN;

        [JsonProperty("IdSalary")]
        public override int Id { get; set; }
        public int SalaryAmount { get; set; }
        public int HoursWorked { get; set; }
        public DateTime DateOfGive { get; set; }
        public int PrizeAmount { get; set; }
        public int IdWorker { get; set; }
        [JsonIgnore]
        public string WorINN
        {
            get => _worINN; set
            {
                _worINN = value;
                OnPropertyChanged();
            }
        }

        [JsonIgnore]
        public override string Path { get; set; } = "Salaries";


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
