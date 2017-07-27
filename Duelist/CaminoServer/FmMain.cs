using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaminoServer
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        #region state machine

        public void StateMachineUpdate(int state)
        {
            Console.WriteLine("Server state machine running state " + state.ToString());

            if (state == 1)
            {
                MdGlobal.GameData.CurrentStatus = "Connecting to server...";
            }
            else if (state == 2)
            {
                MdGlobal.GameData.CurrentStatus = "Player 1: " + MdGlobal.GameData.Players[0].Nickname + " has joined, awaiting player 2";

            }
            else if (state == 3) // assuming a 2 player game, the cycle begins here
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is drawing a card";

            }
            else if (state == 4)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is sacrificing a card";


            }
            else if (state == 5)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is performing an action";


            }
            else if (state == 6)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is casting a spell";


            }
            else if (state == 7)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + "'s unit is attacking";


            }
            else if (state == 8) // assuming a 2 player game, the cycle begins here
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " is drawing a card";

            }
            else if (state == 9)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " is sacrificing a card";


            }
            else if (state == 10)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[2].Nickname + " is performing an action";


            }
            else if (state == 11)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[3].Nickname + " is casting a spell";


            }
            else if (state == 12)
            {
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[4].Nickname + "'s unit is attacking";


            }
            else if (state == 13)
            {
                //TODO:
                // player has won message here

            }

            SetLStatus(MdGlobal.GameData.CurrentStatus);

        }

        #endregion state machine


        #region ui helpers

        public void SetLStatus(string input)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.LStatus.Text = input));
            }
            else
            {

                LStatus.Text = input;
            }
        }
        #endregion ui helpers
    }
}
