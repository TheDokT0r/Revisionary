using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Revisionary
{
    public class MannageSets //Saves/Load sets of cards
    {
        static string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.Revisionary";

        static string SetsPath = rootPath + "/Sets/";

        public static void checkFolder() //Checks if the sets folder exists. If not, then it creates it
        {
            if(!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }

            if (!Directory.Exists(SetsPath))
            {
                Directory.CreateDirectory(SetsPath);
            }

            string usrPath = rootPath + "/usr";
            if (!Directory.Exists(usrPath))
            {
                Directory.CreateDirectory(usrPath);
            }
        }

        public static void SaveSet(CardsSet set)
        {
            Card[] cards = set.cards;
            string setName = set.title;
            string subject = set.subject;

            checkFolder();
            string jsonPath = SetsPath + set.title + ".cardsSet";
            var file = File.Create(jsonPath);
            file.Close();

            //Insets data to the json file
            Dictionary<object, object> json = new Dictionary<object, object>();
            json.Add("name", setName);
            json.Add("subject", subject);

            var cardsArray = setCardsArray(cards).ToArray(); //sets the cards to an array of dictionaries so it could be added to the json file easier
            json.Add("cards", cardsArray);


            string output = JsonConvert.SerializeObject(json, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            File.WriteAllText(jsonPath, output);
        }


        private static List<Dictionary<object, object>> setCardsArray(Card[] cards)
        {
            var lst = new List<Dictionary<object, object>>();

            foreach (Card card in cards)
            {
                Dictionary<object, object> cardData = new Dictionary<object, object>();
                cardData.Add("question", card.question);
                cardData.Add("answer", card.rightAnswer);
                cardData.Add("wrong", card.wrongAnswers);

                lst.Add(cardData);
            }

            return lst;
        }


        public static CardsSet[] getAllSets()
        {
            var sets = new List<CardsSet>();

            string[] files = Directory.GetFiles(SetsPath, "*.cardsSet", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                using (StreamReader r = new StreamReader(file))
                {
                    string json = r.ReadToEnd();
                    dynamic setData = JsonConvert.DeserializeObject(json);
                    CardsSet cardsSet = new CardsSet(Convert.ToString(setData.name), Convert.ToString(setData.subject), GetCardsFromJson(setData.cards));
                    sets.Add(cardsSet);
                }
            }

            return sets.ToArray();
        }


        public static string[] getAllSetsPaths()
        {
            return Directory.GetFiles(SetsPath, "*.cardsSet", SearchOption.AllDirectories);
        }


        static Card[] GetCardsFromJson(dynamic cardsJson) //The code is god aweful
        {
            List<Card> cards = new List<Card>();

            foreach (var card in cardsJson)
            {
                var wrongAnswers = new List<string>();
                foreach (var wrong in card.wrong) //For some reason you HAVE to verify that everything is a string, or else JSON fucking explodes for some reasons
                {
                    wrongAnswers.Add(Convert.ToString(wrong));
                }

                Card currentCard = new Card(Convert.ToString(card.question), Convert.ToString(card.answer), wrongAnswers.ToArray());
                cards.Add(currentCard);
            }

            return cards.ToArray();
        }


        public static void ImportSets() //Import other people's sets
        {
            var sourcePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Revisionary Card Sat File (*.cardsSet)|*.cardsSet";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    sourcePath = openFileDialog.FileName;
                }
            }


            string fileName = Path.GetFileName(sourcePath);

            //Checks if a file with the same name already exists in the dir, and if overwrite over it
            DialogResult result = DialogResult.No;

            if (File.Exists(Path.Combine(SetsPath, fileName)))
            {
                result = MessageBox.Show("FIle with the same name already exists, would you like to overwrite it?", "File already exist", MessageBoxButtons.YesNo);
            }

            bool overwrite = false;
            if(result == DialogResult.Yes)
            {
                overwrite = true;
            }

            try
            {
                File.Copy(sourcePath, Path.Combine(SetsPath, fileName), overwrite);
                MessageBox.Show("Set was imported seccesfuly");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error, couldn't copy this file to the sets directory\n" + e, "Error");
            }
        }


        public static void ExportSet(string ogSetPath)
        {
            string fileName = Path.GetFileName(ogSetPath);

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    File.Copy(ogSetPath, fbd.SelectedPath + "/" + fileName, true);
                }
            }
        }


        public static bool isValidJson(dynamic cardsJson) //Checks if the json is valid
        {
            try
            {
                List<Card> cards = new List<Card>();

                foreach (var card in cardsJson)
                {
                    var wrongAnswers = new List<string>();
                    foreach (var wrong in card.wrong) //For some reason you HAVE to verify that everything is a string, or else JSON fucking explodes for some reasons
                    {
                        wrongAnswers.Add(Convert.ToString(wrong));
                    }

                    Card currentCard = new Card(Convert.ToString(card.question), Convert.ToString(card.answer), wrongAnswers.ToArray());
                    cards.Add(currentCard);
                }
            }
            catch
            {
                return false;
            }

            return true;
        }


        public static void modifySet(CardsSet set)
        {
            //loop over all files in SetsPath
            string[] files = Directory.GetFiles(SetsPath, "*.cardsSet", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                if (Path.GetFileName(file) == set.title + ".cardsSet")
                {
                    using (StreamReader r = new StreamReader(file))
                    {
                        string json = r.ReadToEnd();
                        dynamic setData = JsonConvert.DeserializeObject(json);
                        setData.name = set.title;
                        setData.subject = set.subject;
                        setData.cards = setCardsArray(set.cards);

                        string output = JsonConvert.SerializeObject(setData, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                        File.WriteAllText(file, output);
                    }
                }
            }
        }

        public static void removeSet(CardsSet set)
        {
            string[] files = Directory.GetFiles(SetsPath, "*.cardsSet", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                string fPath = set.title + ".cardsSet";
                if (Path.GetFileName(file) == fPath)
                {
                    try
                    {
                        File.Delete(file);
                        //MessageBox.Show(file);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Cannot remove this file: " + e.Message);
                    }
                }
            }
        }
    }
}
