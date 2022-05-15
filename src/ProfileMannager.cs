using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Revisionary
{
    public class ProfileMannager
    {
        static string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.Revisionary";
        static string profileDir = rootPath + "/usr/";
        static string usrDataFile = profileDir + "/pf.you";
        static string usrStuts = profileDir + "/stuts.you";
        public static void SetProfileFiles()
        {
            if (!Directory.Exists(profileDir))
            {
                Directory.CreateDirectory(profileDir);
            }

            if (!File.Exists(usrDataFile))
            {
                var f = File.Create(usrDataFile);
                f.Close();

                SetProfileFile();
            }

            if (!File.Exists(usrStuts))
            {
                MannageStuts.CreateFile();
            }
        }


        public static void SetProfileFile()
        {
            Dictionary<object, object> json = new Dictionary<object, object>();

            json.Add("name", Environment.UserName);
            json.Add("games_played", 0);
            json.Add("perfect_games", 0);
            json.Add("sets_created", 0);
            json.Add("minutes_practiced", 0);

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }


        public static void ChangeName(string newName)
        {
            string rawJson;
            using (var reader = new StreamReader(usrDataFile))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);
            json.name = newName;

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }


        public static void ChangeData(string key, string newValue)
        {
            dynamic json = JsonConvert.DeserializeObject(usrDataFile);
            json[key] = newValue;


            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }


        public static dynamic GetAllData()
        {
            string rawJson;
            using (var reader = new StreamReader(usrDataFile))
            {
                rawJson = reader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject(rawJson);
        }


        public static void CreatedSet()
        {
            string rawJson;
            using (var reader = new StreamReader(usrDataFile))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);
            //int setsCreated = int.Parse(json.setsCreate) + 1;
            json.sets_created += 1;

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }


        public static void updatePerfectGames(int amountAdd)
        {
            string rawJson;
            using (var reader = new StreamReader(usrDataFile))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);
            json.perfect_games += amountAdd;

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }


        public static void updateGamesPlayed()
        {
            string rawJson;
            using (var reader = new StreamReader(usrDataFile))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);
            json.games_played += 1;

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }


        public static void updateTimePlayed(double mints)
        {
            string rawJson;
            using (var reader = new StreamReader(usrDataFile))
            {
                rawJson = reader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(rawJson);

            string mintsString = Convert.ToString(mints).Substring(0, 4);

            json.minutes_practiced += Convert.ToDouble(mintsString);

            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(usrDataFile, output);
        }
    }
}
