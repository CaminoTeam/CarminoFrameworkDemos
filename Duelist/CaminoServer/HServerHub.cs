using CaminoLib;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoServer
{
    [HubName("HServerHub")]
    public class HServerHub : Hub
    {

        public void RequestJoinGame(string nick)
        {

            if (MdGlobal.GameData.Players.Count < MdGlobal.MAX_PLAYERS)
            {
                Console.WriteLine("Server added new player " + MdGlobal.GameData.Players.Count.ToString());
                int playID = MdGlobal.GameData.Players.Count;
                MdGlobal.GameData.Players.Add(new ClPlayer(nick));
                MdGlobal.GameData.CurrentPlayer = 0;
                MdGlobal.GameData.CurrentState++;
                Clients.All.ReceivedJoinGameConfirm(MdSerializer.Serialize(new JoinGameConfirm(new ClPlayer(nick), true, playID)));
                Clients.All.ReceivedGameData(MdSerializer.Serialize(MdGlobal.GameData));
            }
            else
            {
                Clients.All.ReceivedJoinGameConfirm(MdSerializer.Serialize(new JoinGameConfirm(new ClPlayer(nick), false, -1)));
            }
        }

        public void DrawCard(int playerID)
        {
            MdGlobal.GameData.Players[playerID].DrawCard();
            if (playerID==0)
            {
                MdGlobal.GameData.CurrentState = 4; // p1 sacrifice
            }
            else
            {
                MdGlobal.GameData.CurrentState = 9; // p2 sacrifice
            }
        }

        public void SacrificeCard(int playerID, int cardIndex)
        {
            MdGlobal.GameData.Players[playerID].Hand.RemoveAt(cardIndex);
            MdGlobal.GameData.Players[playerID].MaxMana += 1;
            MdGlobal.GameData.Players[playerID].Mana += 1;
            if (playerID == 0)
            {
                MdGlobal.GameData.CurrentState = 5; // p1 play hub
            }
            else
            {
                MdGlobal.GameData.CurrentState = 10; // p2 play hub
            }

        }

        public void PlayCard(int playerID, int cardIndex)
        {
            var card = MdGlobal.GameData.Players[playerID].Hand[cardIndex];
            MdGlobal.GameData.Players[playerID].Mana -= card.CardCost; // do mana check at client
            if (card.CardType == 0) // is spell
            {
                if (MdUI.MainForm != null)
                {

                    if (MdUI.MainForm.InvokeRequired)
                    {
                        MdUI.MainForm.Invoke(new Action(() => MdUI.MainForm.CastSpell(card.CardID,playerID)));
                    }
                    else
                    {
                        MdUI.MainForm.CastSpell(card.CardID, playerID);
                    }
                }

            }
            else if (card.CardType == 1) // is unit
            {

                if (MdUI.MainForm != null)
                {

                    if (MdUI.MainForm.InvokeRequired)
                    {
                        MdUI.MainForm.Invoke(new Action(() => MdUI.MainForm.AddUnit(card.CardID, playerID)));
                    }
                    else
                    {
                        MdUI.MainForm.AddUnit(card.CardID, playerID);
                        UpdateGameData();
                    }
                }
            }
        }

        public void EndTurn(int playerID)
        {
            if (playerID == 0)
            {
                MdGlobal.GameData.CurrentState = 8;
            }
            else
            {
                MdGlobal.GameData.CurrentState = 3;
            }
        }

        public static void UpdateGameData()
        {
            Console.WriteLine("Server update GameData to clients :" + MdGlobal.GameData.ToString());
            var hc = GlobalHost.ConnectionManager.GetHubContext<HServerHub>();
            hc.Clients.All.ReceivedGameData(MdSerializer.Serialize(MdGlobal.GameData));
        }
        

    }
}
