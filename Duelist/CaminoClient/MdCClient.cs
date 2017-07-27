﻿using CaminoLib;
using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoClient
{
    public class MdCClient
    {
        public static string Url;
        public static IHubProxy SRHub;

        public static void Init()
        {
            var connection = new HubConnection(Url);
            SRHub = connection.CreateHubProxy("HServerHub");
            connection.Start().Wait();
            Console.WriteLine("Client connected to SignalR Hub");
            // add event handlers for SignalR here
            SRHub.On("ReceivedJoinGameConfirm", x => MdUI.MainForm.Invoke(new Action(() => ReceivedJoinGameConfirm(x))));
            SRHub.On("ReceivedGameData", x => MdUI.MainForm.Invoke(new Action(() => ReceivedGameData(x))));
            SRHub.On("ReceiveStatusUpdate", x => MdUI.MainForm.Invoke(new Action(() => ReceiveStatusUpdate(x))));

        }


        public static void ReceivedJoinGameConfirm(string input)
        {
            JoinGameConfirm jgc = MdSerializer.Deserialize<JoinGameConfirm>(input);
            if (jgc.Confirm && MdGlobal.Nickname == jgc.Player.Nickname)
            {
                Console.WriteLine("Client joined game as player " + jgc.PlayerID.ToString());
                MdGlobal.PlayerID = jgc.PlayerID;
            }
            else
            {
                // game ends
                Console.WriteLine("Client failed join game as player " + jgc.PlayerID.ToString());
                MdUI.MainForm.SetLStatus("Server denied your join request");
            }

        }

        public static void ReceivedGameData(string input)
        {
            ClGameData gd = MdSerializer.Deserialize<ClGameData>(input);
            //System.Windows.Forms.MessageBox.Show(gd.Players[0].Hand.Count.ToString());
            bool stateChanged = false;
            if (gd.CurrentState != MdGlobal.GameData.CurrentState)
            {
                stateChanged = true;
            }
            MdGlobal.GameData = gd;
            Console.WriteLine("Client update GameData from Server with state " + gd.CurrentState.ToString());
            MdUI.MainForm.SetLStatus(gd.CurrentStatus);
            MdUI.MainForm.UpdatePlayerStatuses();
            if (stateChanged)
            {
                if (MdUI.MainForm != null)
                {

                    if (MdUI.MainForm.InvokeRequired)
                    {
                        MdUI.MainForm.Invoke(new Action(() => MdUI.MainForm.StateMachineUpdate(gd.CurrentState)));
                    }
                    else
                    {

                        MdUI.MainForm.StateMachineUpdate(gd.CurrentState);
                    }
                }
            }
        }
        
        public static void ReceiveStatusUpdate(string input)
        {
            MdUI.MainForm.SetLStatus(input);
        }

        public static void SendJoinGameRequest()
        {
            SRHub.Invoke("RequestJoinGame", MdGlobal.Nickname);
        }

        public static void DrawCard()
        {
            SRHub.Invoke("DrawCard", MdGlobal.PlayerID);

        }

        public static void SacrificeCard(int cardIndex)
        {
            SRHub.Invoke("SacrificeCard", MdGlobal.PlayerID, cardIndex);

        }

        public static void SkipSacrifice()
        {
            SRHub.Invoke("SkipSacrifice", MdGlobal.PlayerID);

        }
        public static void PlayCard(int cardIndex)
        {
            SRHub.Invoke("PlayCard", MdGlobal.PlayerID, cardIndex);

        }

        public static void EndTurn()
        {
            SRHub.Invoke("EndTurn", MdGlobal.PlayerID);

        }

    }
}
