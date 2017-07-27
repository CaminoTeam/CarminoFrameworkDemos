using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    public class Card
    {
        public int CardType { get; set; }
        public int CardID { get; set; }

        public Card()
        {
            CardType = -1;
            CardID = -1;
        }

        public Card(int type, int id) : this()
        {
            this.CardType = type;
            this.CardID = id;
        }
    }
}
