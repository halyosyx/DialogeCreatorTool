using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class CharacterDialogue
    {
        public static int count { get; set; } = 0;
        public int Id { get; set; }
        public int characterType { get; set; }
        public string characterName { get; set; }
        public string characterImg { get; set; }
        public string  characterDialogue { get; set; }

        public CharacterDialogue( int charType, string charName, string charImg, string charDialogue)
        {
            characterType = charType;
            characterName = charName;
            characterImg = charImg;
            characterDialogue = charDialogue;
            Id = count;

            count++;
        }
    }
}
