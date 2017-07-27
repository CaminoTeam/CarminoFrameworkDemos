using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaminoLib;
namespace CaminoServer
{
    public partial class UCUnit : UserControl
    {
        public Unit UnitData { get; set; }

        public event EventHandler Clicked;

        public UCUnit()
        {
            InitializeComponent();
            UnitData = new Unit();
        }

        public UCUnit(Card card, int owner) : this()
        {
            UnitData = new Unit(card.CardID, owner);
        }
        
        public void SetUIToNormal()
        {
            if (UnitData.Owner == 0)
            {
                if (UnitData.HasAction)
                {

                    PBUnit.Image = MdSprites.P1Units[UnitData.UnitID];
                }
                else
                {
                    PBUnit.Image = MdSprites.P1UnitsExhaust[UnitData.UnitID];
                }
            }
            else
            {
                if (UnitData.HasAction)
                {

                    PBUnit.Image = MdSprites.P2Units[UnitData.UnitID];
                }
                else
                {
                    PBUnit.Image = MdSprites.P2UnitsExhaust[UnitData.UnitID];
                }

            }
        }

        public void SetUIToTarget()
        {
            if (UnitData.Owner == 0)
            {
                PBUnit.Image = MdSprites.P1UnitsSelect[UnitData.UnitID];
            }
            else
            {
                PBUnit.Image = MdSprites.P2UnitsSelect[UnitData.UnitID];
            }
        }

        private void PBUnit_Click(object sender, EventArgs e)
        {

            if (this.Clicked != null)
            {
                this.Clicked(this, e);
            }
        }
    }
}
