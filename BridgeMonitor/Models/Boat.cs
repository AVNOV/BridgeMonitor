using System;
using Newtonsoft.Json;

namespace BridgeMonitor.Models
{
    public class Boat
    {
        public string _boatName { get; set; }
        public string _closingType { get; set; }
        public DateTime _closingDate { get; set; }
        public DateTime _reopeningDate { get; set; }
        public TimeSpan _blockDuree { get; set; }
        public string _jamRisks { get; set; }
    }
}