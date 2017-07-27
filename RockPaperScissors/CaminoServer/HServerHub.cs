﻿using CaminoLib;
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

        public void SendHand(int hand, int player)
        {
            Console.WriteLine("Server received hand from " + player.ToString() + " value " + hand.ToString());
            MdGlobal.GameData.Players[player].CurrentHand = hand;
            Clients.All.ReceivedGameData(MdSerializer.Serialize(MdGlobal.GameData));

            if (MdGlobal.GameData.Players[0].CurrentHand != -1 && MdGlobal.GameData.Players[1].CurrentHand != -1)
            {
                MdGlobal.GameData.CurrentState++;
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
