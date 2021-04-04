using System;
using System.Globalization;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;

namespace BridgeMonitor.Models
{
    public class Boats
    {
        public List<Boat> _boatsInfo { get; set; }
        public DateTime _actual;
        public Boat _NextClosing;

        public Boats () {
            _actual = DateTime.Today;
            _boatsInfo = FormatBoatsFromApi();
            _NextClosing = FindNextClosing(_boatsInfo, _actual);
            
            foreach (var item in _boatsInfo)
            {
                item._blockDuree = GetBlockDuree(item);
                item._jamRisks = (GetJamRisks(item._closingDate, item._blockDuree) == 0) ? "Faible" : "Elevée";
            }
        }

        private static Boat FindNextClosing(List<Boat> allBoats, DateTime now) {
            Boat res = new Boat();

            res._closingDate = new DateTime(9999, 1, 1);
            foreach (Boat item in allBoats) {
                if (now < item._closingDate && res._closingDate > item._closingDate)
                    res = item;
            }
            return res;
        }

        private static TimeSpan GetBlockDuree(Boat item) {
            return (item._reopeningDate - item._closingDate);
        }

        public static int GetJamRisks(DateTime closingTime, TimeSpan duree) {
            closingTime.ToString(CultureInfo.CreateSpecificCulture("fr-FR"));
            int check = (closingTime.Hour + (int)duree.TotalHours);
            int morningLimit = ((int)duree.TotalHours + 9);
            int afternoonLimit = ((int)duree.TotalHours + 19);

            if (check >= morningLimit && check >= afternoonLimit)
                return 0;
            else
                return 1;
        }

        private static List<Boat> FormatBoatsFromApi() {
            using (var client = new HttpClient()) {
                var response = client.GetAsync("https://api.alexandredubois.com/pont-chaban/api.php");
                var stringResult = response.Result.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Boat>>(stringResult.Result);
                return result;
            }
        }
    }
}