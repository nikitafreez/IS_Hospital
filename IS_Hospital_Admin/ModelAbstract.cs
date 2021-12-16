using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Hospital_Admin
{
    public abstract class ModelAbstract
    {
        public abstract int Id { get; set; }

        public abstract string Path { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}