using System;
using Newtonsoft.Json;

namespace IS_Hospital_Admin.Models
{
    public class Passport : ModelAbstract
    {
        public Passport()
        {
        }

        [JsonProperty("IdPassport")] public override int Id { get; set; }

        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportWhoGive { get; set; }
        public DateTime PassportDateOfGive { get; set; }
        public string PassportFirstName { get; set; }
        public string PassportSecondName { get; set; }
        public string PassportMiddleName { get; set; }
        public string PassportGender { get; set; }
        public DateTime PassportDateOfBirth { get; set; }
        public string PassportLivingPlace { get; set; }

        [JsonIgnore] public override string Path { get; set; } = "Passports";

        [JsonIgnore]
        public string MultiBox
        {
            get { return $"{PassportSeries} {PassportNumber}"; }
        }
    }
}