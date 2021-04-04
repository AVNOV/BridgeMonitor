using System;
using Newtonsoft.Json;

namespace BridgeMonitor.Models
{
    public class Boat
    {
        [JsonProperty("boat_name")]
        public string _boatName { get; set; }

        [JsonProperty("closing_type")]
        public string _closingType { get; set; }

        [JsonProperty("closing_date")]
        public DateTime _closingDate { get; set; }

        [JsonProperty("reopening_date")]
        public DateTime _reopeningDate { get; set; }
        public TimeSpan _blockDuree { get; set; }
        
        public string _jamRisks { get; set; }
    }
}