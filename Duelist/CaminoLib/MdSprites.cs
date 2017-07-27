using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CaminoLib
{
    public class MdSprites
    {
        public static string SpriteDir = "GameData/Sprites";
        public static List<Image> P1Units;
        public static List<Image> P2Units;
        public static List<Image> P1UnitsSelect;
        public static List<Image> P2UnitsSelect;
        public static List<Image> P1UnitsAttack;
        public static List<Image> P2UnitsAttack;
        public static List<Image> P1UnitsExhaust;
        public static List<Image> P2UnitsExhaust;

        public static List<Image> P1Spells;
        public static List<Image> P2Spells;
        public static List<Image> P1SpellsSelect;
        public static List<Image> P2SpellsSelect;

        public static Image P1Avatar;
        public static Image P2Avatar;
        public static Image P1AvatarSelect;
        public static Image P2AvatarSelect;



        public static void Init()
        {
            P1Avatar = Image.FromFile(SpriteDir + "/p_1.png");
            P2Avatar = Image.FromFile(SpriteDir + "/p_2.png");
            P1AvatarSelect = Image.FromFile(SpriteDir + "/p_1s.png");
            P2AvatarSelect = Image.FromFile(SpriteDir + "/p_2s.png");

            P1Units = new List<Image>();
            P1UnitsSelect = new List<Image>();
            P1UnitsAttack = new List<Image>();
            P1UnitsExhaust = new List<Image>();

            P2Units = new List<Image>();
            P2UnitsSelect = new List<Image>();
            P2UnitsAttack = new List<Image>();
            P2UnitsExhaust = new List<Image>();
            foreach (var s in Directory.GetFiles(SpriteDir + "/Units"))
            {
                var img = Image.FromFile(s);
                var img2 = Image.FromFile(s);
                img2.RotateFlip(RotateFlipType.Rotate180FlipNone);
                if (s.EndsWith("s.png"))
                {
                    P1UnitsSelect.Add(img);
                    P2UnitsSelect.Add(img2);
                }
                else if (s.EndsWith("a.png"))
                {
                    P1UnitsAttack.Add(img);
                    P2UnitsAttack.Add(img2);
                }
                else if (s.EndsWith("e.png"))
                {

                    P1UnitsExhaust.Add(img);
                    P2UnitsExhaust.Add(img2);
                }
                else
                {
                    P1Units.Add(img);
                    P2Units.Add(img2);
                }
            }

            P1Spells = new List<Image>();
            P1SpellsSelect = new List<Image>();

            P2Spells = new List<Image>();
            P2SpellsSelect = new List<Image>();
            foreach (var s in Directory.GetFiles(SpriteDir + "/Spells"))
            {
                var img = Image.FromFile(s);
                var img2 = Image.FromFile(s);
                img2.RotateFlip(RotateFlipType.Rotate180FlipNone);
                if (s.EndsWith("s.png"))
                {
                    P1SpellsSelect.Add(img);
                    P2SpellsSelect.Add(img2);
                }
                else
                {
                    P1Spells.Add(img);
                    P2Spells.Add(img2);
                }
            }

        }
    }
}
