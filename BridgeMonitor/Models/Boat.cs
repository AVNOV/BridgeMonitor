using System;
using Newtonsoft.Json;

namespace BridgeMonitor.Models
{
    public class Boat
    {
        [JsonProperty("boat_name")]
        public string boatName { get; set; }

        [JsonProperty("closing_type")]
        public string closingType { get; set; }

        [JsonProperty("closing_date")]
        public DateTime closingDate { get; set; }
        
        [JsonProperty("reopening_date")]
        public DateTime reopeningDate { get; set; }
    }
}