using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IS_Hospital.Models
{
    public class Position : ModelAbstract
        , INotifyPropertyChanged
    {
        public Position()
        {
            Task.Run(async () =>
            {
                DepName = (await new Department() { Id = IdDepartment }.Get()).DepartmentName;
            });
        }

        private string _depName;

        [JsonProperty("IdPosition")]
        public override int Id { get; set; }

        public string PositionName { get; set; }
        public int PositionSalary { get; set; }
        public int IdDepartment { get; set; }
        [JsonIgnore]
        public string DepName
        {
            get => _depName; set
            {
                _depName = value;
                OnPropertyChanged();
            }
        }
        
        [JsonIgnore]
        public override string Path { get; set; } = "Positions";

        public event PropertyChangedEventHandler? PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}