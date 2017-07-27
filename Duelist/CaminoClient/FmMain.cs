using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaminoClient
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            SetLPlayerName(MdGlobal.Nickname);
        }

        #region state machine

        // all operations in here should be preceeded with a thread check, everything in here should be thread safe
        public void StateMachineUpdate(int state)
        {
            Console.WriteLine("Client state machine switch to state " + state.ToString());

            if (state == 1)
            {
                // do nothing
            }
            else if (state == 2)
            {
                // do nothing
            }
            else if (state == 3) // assuming a 2 player game, the cycle begins here
            {
                if (MdGlobal.PlayerID == 0)
                {
                    RefreshHand();
                    LButtonDesc.Text = "Draw a Card";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }

            }
            else if (state == 4)
            {
                if (MdGlobal.PlayerID == 0)
                {
                    foreach(UCCard cd in FLPMain.Controls)
                    {
                        cd.SetUIToSacrifice();
                    }
                    LButtonDesc.Text = "Skip sacrifice";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }


            }
            else if (state == 5)
            {
                if (MdGlobal.PlayerID == 0)
                {
                    foreach (UCCard cd in FLPMain.Controls)
                    {
                        cd.SetUIToNormal();
                    }
                    LButtonDesc.Text = "End Turn";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }


            }
            else if (state == 6)
            {
                if (MdGlobal.PlayerID == 0)
                {
                    LButtonDesc.Text = "Cast spell";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }
            }
            else if (state == 7)
            {
                if (MdGlobal.PlayerID == 0)
                {
                    LButtonDesc.Text = "Select attack target";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }
            }
            else if (state == 8) // assuming a 2 player game, the second player cycle begins here
            {
                if (MdGlobal.PlayerID == 1)
                {
                    RefreshHand();
                    LButtonDesc.Text = "Draw a Card";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }
            }
            else if (state == 9)
            {
                if (MdGlobal.PlayerID == 1)
                {
                    foreach (UCCard cd in FLPMain.Controls)
                    {
                        cd.SetUIToSacrifice();
                    }
                    LButtonDesc.Text = "Skip sacrifice";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }
            }
            else if (state == 10)
            {
                if (MdGlobal.PlayerID == 1)
                {
                    foreach (UCCard cd in FLPMain.Controls)
                    {
                        cd.SetUIToNormal();
                    }
                    LButtonDesc.Text = "End Turn";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }
            }
            else if (state == 11)
            {
                if (MdGlobal.PlayerID == 1)
                {
                    LButtonDesc.Text = "Cast spell";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }


            }
            else if (state == 12)
            {

                if (MdGlobal.PlayerID == 1)
                {
                    LButtonDesc.Text = "Select attack target";
                }
                else
                {
                    LButtonDesc.Text = "Waiting for other player";
                }
            }
            else if (state == 13)
            {
                //TODO:player has won message here


            }


            if (state > 2)
            {

                UpdatePlayerStatuses();
            }
            SetLStatus(MdGlobal.GameData.CurrentStatus);

        }


        #endregion state machine


        // provides thread safe ui updates
        #region uiupdates

        private void RefreshHand()
        {
            FLPMain.Controls.Clear();
            foreach(var cd in MdGlobal.GameData.Players[MdGlobal.PlayerID].Hand)
            {
                var ucd = new UCCard(cd);
                ucd.Clicked += (sender, e) => ClickedCard(sender, e);
                ucd.Parent = FLPMain;
            }
        }

        public void SetLPlayerName(string input)
        {
            if (LPlayerName.InvokeRequired)
            {
                this.Invoke(new Action(() => LPlayerName.Text = input));
            }
            else
            {
                LPlayerName.Text = input;
            }
        }

        public void SetLStatus(string input)
        {
            if (LStatus.InvokeRequired)
            {
                this.Invoke(new Action(() => LStatus.Text = input));
            }
            else
            {
                LStatus.Text = input;
            }
        }

        public void UpdatePlayerStatuses()
        {
            var ps = MdGlobal.GameData.Players;
            this.LPlayer1Info.Text = ps[0].Nickname;
            LHealthPlayer1.Text = "HP: " + ps[0].Health.ToString();
            LManaPlayer1.Text = "MP: " + ps[0].Mana.ToString() + "/" + ps[0].MaxMana.ToString();
            LCardPlayer1.Text = "Card: " + ps[0].Hand.Count.ToString() + "/" + ps[0].Deck.Count.ToString();
            

            this.LPlayer2Info.Text = ps[1].Nickname;
            LHealthPlayer2.Text = "HP: " + ps[1].Health.ToString();
            LManaPlayer2.Text = "MP: " + ps[1].Mana.ToString() + "/" + ps[1].MaxMana.ToString();
            LCardPlayer2.Text = "Card: " + ps[1].Hand.Count.ToString() + "/" + ps[1].Deck.Count.ToString();


        }

        #endregion uiupdates

        #region ui event handlers

        private void BtJoinGame_Click(object sender, EventArgs e)
        {

            MdCClient.SendJoinGameRequest();
            BtJoinGame.Visible = false;
        }

        #endregion ui event handlers

        private void FmMain_Load(object sender, EventArgs e)
        {

        }

        private void ClickedCard(object sender, EventArgs e)
        {

        }
    }
}
