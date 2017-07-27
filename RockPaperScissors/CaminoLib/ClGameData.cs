using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    // put game stats, player count, etc in here
    public class ClGameData
    {
        public List<ClPlayer> Players { get; set; }
        public int CurrentPlayer { get; set; }
        public string CurrentStatus { get; set; }

        private int _CurrentState;

        public int CurrentState
        {
            get { return _CurrentState; }
            set
            {
                // calls state changed
                bool hasChanged = false;
                if (_CurrentState != value)
                {
                    hasChanged = true;
                }
                _CurrentState = value;

                if (hasChanged)
                {
                    if (StateChanged != null)
                    {
                        StateChanged(this, EventArgs.Empty);
                    }
                }
            }
        }


        /*
         * state 1: waiting for 1st player
         * state 2: waiting for 2nd player
         * state 3: player1 turn
         * state 4: player2 turn
         * state 5: show results
         * state 6: either win or loopback to state 3
         */

        public event EventHandler StateChanged;

        public ClGameData()
        {
            Players = new List<ClPlayer>();
            CurrentStatus = "Waiting for player 1 to connect";
            CurrentPlayer = -1;
            CurrentState = 1;
            
        }
    }
}
