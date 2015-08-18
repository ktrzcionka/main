using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BankApp
{
    public class SingleAccountInfo
    {
        [JsonProperty(PropertyName = "bankName")]
        public string bankName { get; set; }

        [JsonProperty(PropertyName = "accountType")]
        public string accountType { get; set; }


    }

    
}
