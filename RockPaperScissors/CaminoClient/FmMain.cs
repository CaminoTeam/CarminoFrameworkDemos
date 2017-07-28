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
        bool SelectedHand = false;
        public FmMain()
        {
            InitializeComponent();
            SetLPlayerName(MdGlobal.Nickname);
        }


        //game logic
        public void StateMachineUpdate(int state)
        {
            Console.WriteLine("Client state machine switch to state " + state.ToString());
            if (state == 1)
            {
                
            }
            else if (state == 2)
            {
                
            }
            else if (state == 3)
            {
                SelectedHand = false;
                PBPaper.Visible = true;
                PBRock.Visible = true;
                PBScissors.Visible = true;
            }
            else if (state == 4)
            {
            }
            SetLStatus(MdGlobal.GameData.CurrentStatus);
        }


        #region uiupdates
        

        public void UpdateResults()
        {
            //TODO:
            LScore.Text = "Scores";
            foreach(var p in MdGlobal.GameData.Players)
            {
                LScore.Text = LScore.Text + "\n" + p.Nickname + ": " + p.Score;
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
                this.Invoke(new Action(() => { LStatus.Text = input; UpdateResults();}));
            }
            else
            {
                LStatus.Text = input;
                UpdateResults();
            }
        }

        #endregion uiupdates

        private void BtJoinGame_Click(object sender, EventArgs e)
        {

            MdCClient.SendJoinGameRequest();
            BtJoinGame.Visible = false;
        }

        private void PBRock_Click(object sender, EventArgs e)
        {
            if (MdGlobal.GameData.CurrentState == 3 && SelectedHand == false)
            {
                SelectedHand = true;
                MdCClient.SendHand(1);
                PBPaper.Visible = false;
                PBScissors.Visible = false;
                SetLStatus("You have selected a hand, waiting for the other player");
            }
        }

        private void PBPaper_Click(object sender, EventArgs e)
        {
            if (MdGlobal.GameData.CurrentState == 3 && SelectedHand == false)
            {
                SelectedHand = true;
                MdCClient.SendHand(0);
                PBRock.Visible = false;
                PBScissors.Visible = false;
                SetLStatus("You have selected a hand, waiting for the other player");
            }

        }

        private void PBScissors_Click(object sender, EventArgs e)
        {

            if (MdGlobal.GameData.CurrentState == 3 && SelectedHand == false)
            {
                SelectedHand = true;
                MdCClient.SendHand(2);
                PBRock.Visible = false;
                PBPaper.Visible = false;
                SetLStatus("You have selected a hand, waiting for the other player");
            }
        }
        public bool Pressed { get; set; }
        private void TBBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Pressed == false)
            {
                Pressed = true;
                if (TBBarcode.Text.Contains("rock"))
                {
                    PBRock_Click(PBRock, null);
                }
                else if (TBBarcode.Text.Contains("paper"))
                {
                    PBPaper_Click(PBPaper, null);
                }
                else if (TBBarcode.Text.Contains("scissors"))
                {
                    PBScissors_Click(PBScissors, null);
                }

            }
        }
    }
}
