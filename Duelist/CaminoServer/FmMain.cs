using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaminoLib;
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
                LPlayer1Info.Text = MdGlobal.GameData.Players[0].Nickname;

            }
            else if (state == 3) // assuming a 2 player game, the cycle begins here
            {
                UpdatePlayerStatuses();
                NormalizeUI();
                MdGlobal.GameData.Players[0].Mana = MdGlobal.GameData.Players[0].MaxMana;

                foreach (UCUnit ucu in FLPUnitsPlayer1.Controls)
                {
                    ucu.UnitData.HasAction = true;
                    ucu.SetUIToNormal();
                }
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is drawing a card";


            }
            else if (state == 4)
            {
                UpdatePlayerStatuses();
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is sacrificing a card";


            }
            else if (state == 5)
            {
                UpdatePlayerStatuses();
                PBSpellPlayer1.Visible = false;
                NormalizeUI();

                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is performing an action";


            }
            else if (state == 50)
            {
                UpdatePlayerStatuses();
                MdGlobal.GameData.CurrentState = 5;
            }
            else if (state == 6)
            {
                UpdatePlayerStatuses();
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + " is casting a spell";
                int sp = MdGlobal.GameData.Players[0].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    foreach(UCUnit ucu in FLPUnitsPlayer2.Controls)
                    {
                        if (ucu.UnitData.GetDefense() <= 4)
                        {
                            ucu.SetUIToTarget();
                        }
                    }
                    PBAvatarPlayer2.Image = MdSprites.P2AvatarSelect;
                }
            }
            else if (state == 7)
            {
                UpdatePlayerStatuses();

                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[0].Nickname + "'s unit is attacking";
                PBAvatarPlayer2.Image = MdSprites.P2AvatarSelect;

                foreach (UCUnit ucu in FLPUnitsPlayer2.Controls)
                {
                    if (ucu.UnitData.GetDefense() <= MdGlobal.GameData.Players[0].SelectedUnit.GetAttack())
                    {
                        ucu.SetUIToTarget();
                    }
                }
            }
            else if (state == 8) // assuming a 2 player game, the second player cycle begins here
            {
                UpdatePlayerStatuses();
                NormalizeUI();
                MdGlobal.GameData.Players[1].Mana = MdGlobal.GameData.Players[1].MaxMana;

                foreach (UCUnit ucu in FLPUnitsPlayer2.Controls)
                {
                    ucu.UnitData.HasAction = true;
                    ucu.SetUIToNormal();
                }
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " is drawing a card";

            }
            else if (state == 9)
            {
                UpdatePlayerStatuses();

                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " is sacrificing a card";


            }
            else if (state == 10)
            {
                UpdatePlayerStatuses();
                PBSpellPlayer2.Visible = false;
                NormalizeUI();
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " is performing an action";


            }
            else if (state == 100)
            {

                UpdatePlayerStatuses();
                MdGlobal.GameData.CurrentState = 10;
            }
            else if (state == 11)
            {
                UpdatePlayerStatuses();
                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + " is casting a spell";
                int sp = MdGlobal.GameData.Players[1].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    foreach (UCUnit ucu in FLPUnitsPlayer1.Controls)
                    {
                        if (ucu.UnitData.GetDefense() <= 4)
                        {
                            ucu.SetUIToTarget();
                        }
                    }
                    PBAvatarPlayer1.Image = MdSprites.P1AvatarSelect;

                }


            }
            else if (state == 12)
            {
                UpdatePlayerStatuses();

                MdGlobal.GameData.CurrentStatus = MdGlobal.GameData.Players[1].Nickname + "'s unit is attacking";
                PBAvatarPlayer1.Image = MdSprites.P1AvatarSelect;

                foreach (UCUnit ucu in FLPUnitsPlayer1.Controls)
                {
                    if (ucu.UnitData.GetDefense() <= MdGlobal.GameData.Players[1].SelectedUnit.GetAttack())
                    {
                        ucu.SetUIToTarget();
                    }
                }
            }
            else if (state == 13)
            {
                //TODO:player has won message here
                UpdatePlayerStatuses();


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

        public void RefreshUnitExhaust(int owner) // call this function from the client when end turn is preessed
        { 
            FlowLayoutPanel flp;
            if (owner == 0)
            {
                flp = FLPUnitsPlayer1;
            }
            else
            {
                flp = FLPUnitsPlayer2;
            }
            foreach(UCUnit ucu in flp.Controls)
            {
                ucu.UnitData.HasAction = true;
                ucu.SetUIToNormal();
            }
        }

        public void UpdatePlayerStatuses()
        {
            var ps = MdGlobal.GameData.Players;
            this.LPlayer1Info.Text = ps[0].Nickname;
            LHealthPlayer1.Text = "HP: " + ps[0].Health.ToString();
            LManaPlayer1.Text = "MP: " + ps[0].Mana.ToString() + "/" + ps[0].MaxMana.ToString();
            LCardPlayer1.Text = "Card: " + ps[0].Hand.Count.ToString() + "/" + ps[0].Deck.Count.ToString();

            while (FLPHandPlayer1.Controls.Count > ps[0].Hand.Count)
            {
                FLPHandPlayer1.Controls.RemoveAt(0);
            }

            while (FLPHandPlayer1.Controls.Count < ps[0].Hand.Count)
            {
                var uchc = new UCHandCard();
                uchc.Size = new Size(80, 80);
                FLPHandPlayer1.Controls.Add(uchc);
            }

            this.LPlayer2Info.Text = ps[1].Nickname;
            LHealthPlayer2.Text = "HP: " + ps[1].Health.ToString();
            LManaPlayer2.Text = "MP: " + ps[1].Mana.ToString() + "/" + ps[1].MaxMana.ToString();
            LCardPlayer2.Text = "Card: " + ps[1].Hand.Count.ToString() + "/" + ps[1].Deck.Count.ToString();


            while (FLPHandPlayer2.Controls.Count > ps[1].Hand.Count)
            {
                FLPHandPlayer2.Controls.RemoveAt(0);
            }

            while (FLPHandPlayer2.Controls.Count < ps[1].Hand.Count)
            {
                FLPHandPlayer2.Controls.Add(new UCHandCard());
            }
        }

        #endregion ui helpers

        public void AddUnit(int unitID, int owner) // remember to invoke this function
        {
            var nu = new Unit(unitID, owner);
            Console.WriteLine("Server added unit to player " + nu.Owner.ToString() + " with id " + nu.UnitID.ToString());
            MdGlobal.GameData.Players[owner].DeployedUnits.Add(nu);
            var ucu = new UCUnit(nu);
            ucu.Clicked += (sender, e) => ClickedUnit(sender, e);
            if (owner == 0)
            {
                ucu.Parent = FLPUnitsPlayer1;
                MdGlobal.GameData.CurrentState = 50;

            }
            else
            {
                ucu.Parent = FLPUnitsPlayer2;
                MdGlobal.GameData.CurrentState = 100;

            }
        }

        public void ClickedUnit(object sender, EventArgs e)
        {
            UCUnit ucu = sender as UCUnit;
            int state = MdGlobal.GameData.CurrentState;

            if (state == 5 && ucu.UnitData.Owner == 0 && ucu.UnitData.HasAction) // player 1 is selecting an attack origin
            {
                ucu.UnitData.HasAction = false;
                ucu.SetUIToNormal();

                MdGlobal.GameData.Players[0].SelectedUnit = ucu.UnitData;
                MdGlobal.GameData.CurrentState = 7;
            }
            else if (state == 6 && ucu.UnitData.Owner == 1) // play 1 is selecting a spell target
            {
                int sp = MdGlobal.GameData.Players[0].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    // damage single target 4 hp
                    if (ucu.UnitData.GetDefense() <=4)
                    {
                        MdGlobal.GameData.Players[1].DeployedUnits.Remove(ucu.UnitData);
                        FLPUnitsPlayer2.Controls.Remove(ucu);
                        MdGlobal.GameData.CurrentState = 5;
                    }
                }
            }
            else if (state == 7 && ucu.UnitData.Owner == 1) // play 1 is selecting an attack target
            {
                if (MdGlobal.GameData.Players[0].SelectedUnit.Kills(ucu.UnitData))
                {
                    MdGlobal.GameData.Players[1].DeployedUnits.Remove(ucu.UnitData);
                    FLPUnitsPlayer2.Controls.Remove(ucu);
                    MdGlobal.GameData.CurrentState = 5;

                }
            }
            else if (state == 10 && ucu.UnitData.Owner == 1 && ucu.UnitData.HasAction) // player 2 is selecting an an attack origin
            {
                ucu.UnitData.HasAction = false;
                ucu.SetUIToNormal();
                MdGlobal.GameData.Players[1].SelectedUnit = ucu.UnitData;
                MdGlobal.GameData.CurrentState = 12;

            }
            else if (state == 11 && ucu.UnitData.Owner == 0) // player 2 is selecting a spell target
            {
                int sp = MdGlobal.GameData.Players[1].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    // damage single target 4 hp
                    if (ucu.UnitData.GetDefense() <= 4)
                    {
                        MdGlobal.GameData.Players[0].DeployedUnits.Remove(ucu.UnitData);
                        FLPUnitsPlayer2.Controls.Remove(ucu);
                        MdGlobal.GameData.CurrentState = 10;
                    }
                }
            }
            else if (state == 12 && ucu.UnitData.Owner == 0) // player 2 is selecting an attack target
            {

                if (MdGlobal.GameData.Players[1].SelectedUnit.Kills(ucu.UnitData))
                {
                    MdGlobal.GameData.Players[1].SelectedUnit.HasAction = false;
                    MdGlobal.GameData.Players[0].DeployedUnits.Remove(ucu.UnitData);
                    FLPUnitsPlayer1.Controls.Remove(ucu);
                    MdGlobal.GameData.CurrentState = 10;

                }
            }
        }



        public void CastSpell(int spellID, int owner)
        {
            if (owner == 0)
            {
                PBSpellPlayer1.Visible = true;
                PBSpellPlayer1.Image = MdSprites.P1SpellsSelect[spellID];
                MdGlobal.GameData.Players[0].SelectedSpellID = spellID;
                MdGlobal.GameData.CurrentState = 6;
            }
            else
            {
                PBSpellPlayer2.Visible = true;
                PBSpellPlayer2.Image = MdSprites.P2SpellsSelect[spellID];
                MdGlobal.GameData.Players[1].SelectedSpellID = spellID;
                MdGlobal.GameData.CurrentState = 11;
            }
        }

        private void NormalizeUI()
        {
            PBAvatarPlayer1.Image = MdSprites.P1Avatar;
            PBAvatarPlayer2.Image = MdSprites.P2Avatar;

            foreach (UCUnit ucu in FLPUnitsPlayer1.Controls)
            {
                ucu.SetUIToNormal();
            }

            foreach (UCUnit ucu in FLPUnitsPlayer2.Controls)
            {
                ucu.SetUIToNormal();

            }

        }

        // handles first click casting on spells
        private void PBSpellPlayer1_Click(object sender, EventArgs e)
        {
            if (MdGlobal.GameData.CurrentState == 6)
            {
                int sp = MdGlobal.GameData.Players[0].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    // do nothing
                }
                else if (sp == 1) // arrows
                {
                    // damage 2hp enemy units
                    for (int i = MdGlobal.GameData.Players[1].DeployedUnits.Count-1; i>=0;i--)
                    {
                        var du = MdGlobal.GameData.Players[1].DeployedUnits[i];
                        if (du.GetDefense() <= 2)
                        {
                            MdGlobal.GameData.Players[1].DeployedUnits.RemoveAt(i);
                            FLPUnitsPlayer2.Controls.RemoveAt(i);
                        }

                    }
                    MdGlobal.GameData.CurrentState = 5;

                }
                else if (sp == 2) // nova
                {
                    // kill all units
                    MdGlobal.GameData.Players[0].DeployedUnits.Clear();
                    FLPUnitsPlayer1.Controls.Clear();
                    MdGlobal.GameData.Players[1].DeployedUnits.Clear();
                    FLPUnitsPlayer2.Controls.Clear();
                    MdGlobal.GameData.CurrentState = 5;

                }
                else if (sp == 3) // potion
                {
                    // heal 4 health
                    MdGlobal.GameData.Players[0].Health += 4;
                    MdGlobal.GameData.CurrentState = 5;
                }
                else if (sp == 4) // crystal
                {
                    MdGlobal.GameData.Players[0].Mana += 2;
                    MdGlobal.GameData.Players[0].MaxMana += 2;
                    MdGlobal.GameData.CurrentState = 5;

                }
                else if (sp == 5) // ic
                {
                    // draw two cards
                    MdGlobal.GameData.Players[0].DrawCard();
                    MdGlobal.GameData.Players[0].DrawCard();
                    MdGlobal.GameData.CurrentState = 5;

                }
            }
        }

        private void PBSpellPlayer2_Click(object sender, EventArgs e)
        {
            if (MdGlobal.GameData.CurrentState == 11)
            {
                int sp = MdGlobal.GameData.Players[1].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    // do nothing
                }
                else if (sp == 1) // arrows
                {
                    // damage 2hp enemy units
                    for (int i = MdGlobal.GameData.Players[0].DeployedUnits.Count - 1; i >= 0; i--)
                    {
                        var du = MdGlobal.GameData.Players[0].DeployedUnits[i];
                        if (du.GetDefense() <= 2)
                        {
                            MdGlobal.GameData.Players[0].DeployedUnits.RemoveAt(i);
                            FLPUnitsPlayer1.Controls.RemoveAt(i);
                        }

                    }
                    MdGlobal.GameData.CurrentState = 10;

                }
                else if (sp == 2) // nova
                {
                    // kill all units
                    MdGlobal.GameData.Players[0].DeployedUnits.Clear();
                    FLPUnitsPlayer1.Controls.Clear();
                    MdGlobal.GameData.Players[1].DeployedUnits.Clear();
                    FLPUnitsPlayer2.Controls.Clear();
                    MdGlobal.GameData.CurrentState = 10;

                }
                else if (sp == 3) // potion
                {
                    // heal 4 health
                    MdGlobal.GameData.Players[1].Health += 4;
                    MdGlobal.GameData.CurrentState = 10;
                }
                else if (sp == 4) // crystal
                {
                    MdGlobal.GameData.Players[1].Mana += 2;
                    MdGlobal.GameData.Players[1].MaxMana += 2;
                    MdGlobal.GameData.CurrentState = 10;

                }
                else if (sp == 5) // ic
                {
                    // draw two cards
                    MdGlobal.GameData.Players[1].DrawCard();
                    MdGlobal.GameData.Players[1].DrawCard();
                    MdGlobal.GameData.CurrentState = 10;

                }
            }
        }

        private void PBAvatarPlayer1_Click(object sender, EventArgs e)
        {
            int state = MdGlobal.GameData.CurrentState;
            if (state == 11) // player 2 is selecting a spell target
            {
                int sp = MdGlobal.GameData.Players[1].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    // damage single target 4 hp
                    MdGlobal.GameData.Players[0].Health -= 4;
                    MdGlobal.GameData.CurrentState = 10;
                }
            }
            else if (state == 12) // player 2 is selecting an attack target
            {
                MdGlobal.GameData.Players[0].Health -= MdGlobal.GameData.Players[1].SelectedUnit.GetAttack();
                MdGlobal.GameData.CurrentState = 10;
            }
        }

        private void PBAvatarPlayer2_Click(object sender, EventArgs e)
        {
            int state = MdGlobal.GameData.CurrentState;
            if (state == 6) // player 2 is selecting a spell target
            {
                int sp = MdGlobal.GameData.Players[0].SelectedSpellID;
                if (sp == 0) // fireball
                {
                    // damage single target 4 hp
                    MdGlobal.GameData.Players[1].Health -= 4;
                    MdGlobal.GameData.CurrentState = 5;
                }
            }
            else if (state == 7) // player 2 is selecting an attack target
            {
                MdGlobal.GameData.Players[1].Health -= MdGlobal.GameData.Players[0].SelectedUnit.GetAttack();
                MdGlobal.GameData.CurrentState = 5;
            }
        }
    }
}
