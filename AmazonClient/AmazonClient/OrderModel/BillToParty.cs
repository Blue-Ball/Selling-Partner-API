using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFOrder.Model
{
    public class BillToParty
    {

        [JsonProperty("partyId")]
        public string PartyId { get; set; }
    }
}
