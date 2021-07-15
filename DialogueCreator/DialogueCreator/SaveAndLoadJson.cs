using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DialogueCreator
{
    public class SaveAndLoadJson
    {
        public void SaveJsonFile(string filePath, List<CharacterDialogue> dialogue)
        {
            
            File.WriteAllText(filePath, JsonConvert.SerializeObject(dialogue));
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, dialogue);
            }
        }

        public void LoadJsonFile(string filePath)
        {
            var jDialogue = JsonConvert.DeserializeObject<CharacterDialogue>(filePath);


        }
    }
}
