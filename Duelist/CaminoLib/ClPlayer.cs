using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    // place scores and player unique stuff in here
    public class ClPlayer
    {
        public string Nickname { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> Hand { get; set; }
        public List<Unit> DeployedUnits { get; set; }
        public int SelectedSpellID { get; set; }
        public int SelectedUnitIndex { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }


        public ClPlayer()
        {
            Nickname = "Unnamed Player";
            Deck = GenerateDefaultDeck();
            Hand = new List<Card>();
            DrawCard();
            DrawCard();
            DrawCard();
            DrawCard();
            DrawCard();
            DeployedUnits = new List<Unit>();
            SelectedSpellID = -1;
            SelectedUnitIndex = -1;
            MaxMana = 0;
            Mana = 0;
            Health = 30;
            
        }

        public ClPlayer(string nickname) : this()
        {
            this.Nickname = nickname;
        }

        public bool DrawCard() // returns false if deck is empty, else true
        {
            var output = false;
            if (Deck.Count > 0)
            {
                output = true;
                Hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
            return output;
        }

        private static List<Card> GenerateDefaultDeck()
        {
            var output = new List<Card>();
            //TODO:
            return output;
        }
    }
}
