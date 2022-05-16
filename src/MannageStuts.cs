using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Revisionary
{
    public class MannageStuts
    {
        static string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.Revisionary";
        static string profileDir = rootPath + "/usr/";
        //static string usrDataFile = profileDir + "/pf.you";
        static string usrStuts = profileDir + "/stuts.you";


        public static void CreateFile()
        {
            if(File.Exists(usrStuts))
            {
                return;
            }

            var f = File.Create(usrStuts);
            f.Close();

            var setData = new Dictionary<object, object>();

            setData.Add("set_name", "none");
            setData.Add("subject", "none");
            setData.Add("questionsAmount", -1);
            setData.Add("records", new List<int>(0));
            setData.Add("dates", new List<DateTime>());
            setData.Add("time_played", 0);

            var json = new List<object>();
            json.Add(setData);

            try
            {
                string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                File.WriteAllText(usrStuts, output);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public static void AddRecord(string setName, string subject, int questionsAmount, int amountOfCorrectAnswers, double timePlayed)
        {
            string output;
            string rawJson;
            using (var reader = new StreamReader(usrStuts))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);

            int index = GetIndexOfItem(setName, subject);

            if(index == -1) //Item doesn't exists in the db
            {
                var setData = new Dictionary<object, object>();

                dynamic dateTimesArr = new DateTime[] { DateTime.Now };
                dynamic recordsArr = new int[] { amountOfCorrectAnswers };

                setData.Add("set_name", setName);
                setData.Add("subject", subject);
                setData.Add("questionsAmount", questionsAmount);
                setData.Add("records", recordsArr);
                setData.Add("dates", new List<DateTime>(dateTimesArr));
                setData.Add("time_played", timePlayed);

                var jToken = new JsonToken();

                json.Add(JToken.FromObject(setData));

                output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                File.WriteAllText(usrStuts, output);

                return;
            }


            //If item does exists in the db
            json[index].records.Add(amountOfCorrectAnswers);
            json[index].dates.Add(DateTime.Now);
            json[index].time_played += timePlayed;

            output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrStuts, output);
        }


        private static int GetIndexOfItem(string name, string subject)
        {
            string rawJson;
            using (var reader = new StreamReader(usrStuts))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);

            for(int i = 0; i < json.Count; i++)
            {
                if(Convert.ToString(json[i].set_name) == name && Convert.ToString(json[i].subject) == subject)
                {
                    return i;
                }
            }

            return -1;
        }


        public static void addTime(double mints)
        {
            string rawJson;
            using (var reader = new StreamReader(usrStuts))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);
            json.time_played += mints;

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrStuts, output);
        }

        public static dynamic GetData()
        {
            string rawJson;
            using (var reader = new StreamReader(usrStuts))
            {
                rawJson = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject(rawJson);
        }


        public static dynamic GetDataOfSpecificSet(CardsSet set)
        {
            string name = set.title;
            string subject = set.subject;

            string rawJson;
            using (var reader = new StreamReader(usrStuts))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);

            for (int i = 0; i < json.Count; i++)
            {
                if (Convert.ToString(json[i].set_name) == name && Convert.ToString(json[i].subject) == subject)
                {
                    return json[i];
                }
            }

            return -1;
        }
    }
}
