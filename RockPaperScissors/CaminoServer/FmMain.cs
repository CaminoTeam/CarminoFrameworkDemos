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

        public void StateMachineUpdate(int state)
        {
            if (state == 1)
            {
                MdGlobal.GameData.CurrentStatus = "Waiting for player 1 to connect";
            }
            else if (state == 2)
            {
                MdGlobal.GameData.CurrentStatus = "Waiting for player 2 to connect";
                LPlayer1Stats.Text = "Player 1: " + MdGlobal.GameData.Players[0].Nickname + " | Score : " + MdGlobal.GameData.Players[0].Score.ToString();

            }
            else if (state == 3)
            {
                MdGlobal.GameData.CurrentStatus = "Waiting for players to choose hand";
                LPlayer2Stats.Text = "Player 2: " + MdGlobal.GameData.Players[1].Nickname + " | Score : " + MdGlobal.GameData.Players[1].Score.ToString();

                PB10.Visible = false;
                PB11.Visible = false;
                PB12.Visible = false;
                PB20.Visible = false;
                PB21.Visible = false;
                PB22.Visible = false;
                BtnNext.Visible = false;
                

            }
            else if (state == 4)
            {
                BtnNext.Visible = true;

                var Player1Type = MdGlobal.GameData.Players[0].CurrentHand;
                var Player2Type = MdGlobal.GameData.Players[1].CurrentHand;
                if (Player1Type - Player2Type == 0)
                {
                    MdGlobal.GameData.Players[0].Score++;
                    MdGlobal.GameData.Players[1].Score++;
                    MdGlobal.GameData.CurrentStatus = "It was a tie!";
                }
                else if (Player2Type - Player1Type == 1 || Player1Type - Player2Type == 2)
                {
                    MdGlobal.GameData.Players[0].Score++;
                    MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " won!";
                }
                else
                {
                    MdGlobal.GameData.Players[1].Score++;
                    MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " won!";

                }

                LPlayer1Stats.Text = "Player 1: " + MdGlobal.GameData.Players[0].Nickname + " | Score : " + MdGlobal.GameData.Players[0].Score.ToString();
                LPlayer2Stats.Text = "Player 2: " + MdGlobal.GameData.Players[1].Nickname + " | Score : " + MdGlobal.GameData.Players[1].Score.ToString();
                if (Player1Type == 0)
                {
                    PB10.Visible = true;
                }
                else if (Player1Type == 1)
                {
                    PB11.Visible = true;
                }
                else if (Player1Type == 2)
                {
                    PB12.Visible = true;
                }

                if (Player2Type == 0)
                {
                    PB20.Visible = true;
                }
                else if (Player2Type == 1)
                {
                    PB21.Visible = true;
                }
                else if (Player2Type == 2)
                {
                    PB22.Visible = true;
                }

                HServerHub.UpdateGameData();
                
            }
            SetLStatus(MdGlobal.GameData.CurrentStatus);

            LStateMachineMonitor.Text = state.ToString();

        }
        

        private void BtnNext_Click(object sender, EventArgs e)
        {
            MdGlobal.GameData.CurrentStatus = "Starting new turn, please pick a hand";
            MdGlobal.GameData.Players[0].CurrentHand = -1;
            MdGlobal.GameData.Players[1].CurrentHand = -1;

            MdGlobal.GameData.CurrentState = 3;
        }
    }
}
