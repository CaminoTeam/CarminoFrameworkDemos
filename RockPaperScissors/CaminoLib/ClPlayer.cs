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
        public int Score { get; set; }
        public int CurrentHand { get; set; }

        public ClPlayer()
        {
            Nickname = "Unnamed Player";
            Score = 0;
            CurrentHand = -1;
        }

        public ClPlayer(string nickname) : this()
        {
            this.Nickname = nickname;
        }
    }
}
