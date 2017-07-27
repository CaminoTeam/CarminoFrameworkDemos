using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    public class Card
    {
        public int CardType { get; set; } // type0 is spell, type1 is unit
        public int CardID { get; set; }
        public int CardCost { get; set; }

        public Card()
        {
            CardType = -1;
            CardID = -1;
            CardCost = 0;
        }
        public Card(Card card) : this()
        {
            this.CardType = card.CardType;
            this.CardID = card.CardID;
            this.CardCost = card.CardCost;
        }
        public Card(int type, int id, int cost) : this()
        {
            this.CardType = type;
            this.CardID = id;
            this.CardCost = cost;
        }
    }
}
