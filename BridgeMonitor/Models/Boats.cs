using System;
using System.Globalization;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;

namespace BridgeMonitor.Models
{
    public class Boats
    {
        public List<Boat> _boatsInfo;
        public Boat _NextClosingInfo { get; set; }
        public DateTime _actual = DateTime.Today;

        public Boats() {
            _boatsInfo = new List<Boat>(GetBoatsFromApi());
            _NextClosingInfo = SetEventInfo(_boatsInfo, _actual);
            _NextClosingInfo._jamRisks = (ComputeJamRisks(_NextClosingInfo._closingDate, _NextClosingInfo._blockDuree) == 0) ? "Faible." : "Elevée.";
        }

        public static int ComputeJamRisks(DateTime closingTime, TimeSpan duree) {
            closingTime.ToString(CultureInfo.CreateSpecificCulture("fr-FR"));
            int check = (closingTime.Hour + (int)duree.TotalHours);
            int morningLimit = ((int)duree.TotalHours + 9);
            int afternoonLimit = ((int)duree.TotalHours + 19);

            if (check >= morningLimit && check >= afternoonLimit)
                return 0;
            else
                return 1;
        }
            
        public static Boat SetEventInfo(List<Boat> _boatInfo, DateTime _actual) {
            Boat nextOne = new Boat();

            nextOne._closingDate = new DateTime(9999, 1, 1);
            foreach (Boat item in _boatInfo) {
                if (_actual < item._closingDate && nextOne._closingDate > item._closingDate)
                    nextOne = item;
            }
            nextOne._blockDuree = nextOne._reopeningDate - nextOne._closingDate;
            return nextOne;
        }

        private static List<Boat> GetBoatsFromApi() {
        //Création un HttpClient (= outil qui va permettre d'interroger une URl via une requête HTTP)
            using (var client = new HttpClient()) {
                var response = client.GetAsync("https://api.alexandredubois.com/pont-chaban/api.php");
                var stringResult = response.Result.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Boat>>(stringResult.Result);
                return result;
            }
        }
    }
}