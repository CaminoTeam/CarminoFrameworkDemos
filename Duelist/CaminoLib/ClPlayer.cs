﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    // place scores and player unique stuff in here
    public class ClPlayer
    {
        private static Random rng = new Random();
        public string Nickname { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> Hand { get; set; }
        public List<Unit> DeployedUnits { get; set; }
        public int SelectedSpellID { get; set; }
        public Unit SelectedUnit { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }


        public ClPlayer()
        {
            Nickname = "Unnamed Player";
            Deck = new List<Card>();
            Hand = new List<Card>();
            DeployedUnits = new List<Unit>();
            SelectedSpellID = -1;
            SelectedUnit = null;
            MaxMana = 0;
            Mana = 0;
            Health = 30;
            
        }

        public void Init()
        {

            Deck = GenerateDefaultDeck();
            DrawCard();
            DrawCard();
            DrawCard();
            DrawCard();
            DrawCard();
        }

        public ClPlayer(string nickname) : this()
        {
            this.Nickname = nickname;
        }

        public bool DrawCard() // returns false if deck is empty, else true
        {
            var output = false;
            if (Deck.Count > 0)
            {
                output = true;
                Hand.Add(Deck[0]);
                Deck.RemoveAt(0);
            }
            return output;
        }

        private static List<Card> GenerateDefaultDeck()
        {
            var ls = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                var cd = new Card(0, 0, 4);
                ls.Add(cd);
            }
            for (int i = 0; i < 4; i++)
            {
                var cd = new Card(0, 1, 4);
                ls.Add(cd);
            }
            for (int i = 0; i < 4; i++)
            {
                var cd = new Card(0, 2, 5);
                ls.Add(cd);
            }
            for (int i = 0; i < 4; i++)
            {
                var cd = new Card(0, 3, 4);
                ls.Add(cd);
            }
            for (int i = 0; i < 4; i++)
            {
                var cd = new Card(0, 4, 2);
                ls.Add(cd);
            }
            for (int i = 0; i < 4; i++)
            {
                var cd = new Card(0, 5, 2);
                ls.Add(cd);
            }


            for (int i = 0; i < 5; i++)
            {
                var cd = new Card(1, 0, 1);
                ls.Add(cd);
            }

            for (int i = 0; i < 3; i++)
            {
                var cd = new Card(1, 1, 1);
                ls.Add(cd);
            }
            for (int i = 0; i < 6; i++)
            {
                var cd = new Card(1, 2, 2);
                ls.Add(cd);
            }
            for (int i = 0; i < 6; i++)
            {
                var cd = new Card(1, 3, 2);
                ls.Add(cd);
            }
            for (int i = 0; i < 3; i++)
            {
                var cd = new Card(1, 4, 3);
                ls.Add(cd);
            }
            for (int i = 0; i < 2; i++)
            {
                var cd = new Card(1, 5, 4);
                ls.Add(cd);
            }
            for (int i = 0; i < 2; i++)
            {
                var cd = new Card(1, 6, 5);
                ls.Add(cd);
            }


            int n = ls.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = ls[k];
                ls[k] = ls[n];
                ls[n] = value;
            }



            return ls;
        }
    }
}
