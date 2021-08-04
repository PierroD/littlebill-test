using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LittleBill_test_frontend.Helpers
{
    public class HistoriqueHelpers
    {
        private static string historiqueFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\historique.json";
        private static List<HistoriqueItem> historique = new List<HistoriqueItem>();
        public static void LoadHistoriqe()
        {
            if(File.Exists(historiqueFile))
            {
                historique = JsonConvert.DeserializeObject<List<HistoriqueItem>>(File.ReadAllText(historiqueFile));
            }
        }

        public static void AddToHistorique(dynamic weather)
        {
            historique.Add(new HistoriqueItem { timestamp = DateTime.Now, weather = weather });
        }

        public static void DeleteFromHistorique(HistoriqueItem item)
        {
            historique.Remove(item);
        }

        public static void SaveHistorique()
        {
            if (!File.Exists(historiqueFile))
            {
                using (StreamWriter file = File.CreateText(historiqueFile))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, historique);
                }
            }
            else
            {
                File.Delete(historiqueFile);
                SaveHistorique();
            }
        }

        public static bool isInHistorique(string cityName)
        {
            foreach (dynamic item in historique)
            {
                if (item.name.Equals(cityName))
                    return true;
            }
            return false;
        }

        public static int Count()
        {
            return historique.Count();
        }

        public static List<HistoriqueItem> GetAll()
        {
            return historique;
        }
    }


    public class HistoriqueItem
    {
        public DateTime timestamp { get; set; }
        public dynamic weather { get; set; }
    }
}
