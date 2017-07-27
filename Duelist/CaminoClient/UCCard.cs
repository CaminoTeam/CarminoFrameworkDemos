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
namespace CaminoClient
{
    public partial class UCCard : UserControl
    {
        public Card CardData { get; set; }

        public event EventHandler Clicked;

        public UCCard()
        {
            InitializeComponent();
            CardData = new Card();
        }

        public UCCard(Card card) : this()
        {
            CardData = card;
            SetUIToNormal();
        }
        
        public void SetUIToSacrifice()
        {

            if (CardData.CardType == 0) // is spell
            {
                PBMain.Image = MdSprites.P1SpellsSelect[CardData.CardID];

            }
            else
            {
                PBMain.Image = MdSprites.P1UnitsSelect[CardData.CardID];

            }
        }

        public void SetUIToNormal()
        {

            if (CardData.CardType == 0) // is spell
            {
                PBMain.Image = MdSprites.P1Spells[CardData.CardID];

            }
            else
            {
                PBMain.Image = MdSprites.P1Units[CardData.CardID];

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
