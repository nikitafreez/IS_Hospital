using System;
using Newtonsoft.Json;

namespace IS_Hospital_Admin.Models
{
    public class Department : ModelAbstract
    {
        public Department()
        {
        }
        
        [JsonProperty("IdDepartment")]
        public override int Id { get; set; }

        public string DepartmentName { get; set; }
        public string DepartmentPhoneNumber { get; set; }
        
        [JsonIgnore]
        public override string Path { get; set; } = "Departments";
    }
}