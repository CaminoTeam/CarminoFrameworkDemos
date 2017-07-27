using CaminoLib;
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
            SRHub.On("ReceivedJoinGameConfirm", x => MdUI.MainForm.Invoke(new Action(() => ReceivedJoinGameConfirm(x))));
            SRHub.On("ReceivedGameData", x => MdUI.MainForm.Invoke(new Action(() => ReceivedGameData(x))));

        }


        public static void ReceivedJoinGameConfirm(string input)
        {
            JoinGameConfirm jgc = MdSerializer.Deserialize<JoinGameConfirm>(input);
            if (MdGlobal.Nickname == jgc.Player.Nickname)
            {
                if (jgc.Confirm)
                {

                    Console.WriteLine("Client joined game as player " + jgc.PlayerID.ToString());
                    MdGlobal.PlayerID = jgc.PlayerID;
                }
                else
                {

                    Console.WriteLine("Client failed join game as player " + jgc.PlayerID.ToString());
                    MdUI.MainForm.SetLStatus("Server denied your join request");
                }
            }

        }

        public static void ReceivedGameData(string input)
        {

            ClGameData gd = MdSerializer.Deserialize<ClGameData>(input);
            bool hasChanged = false;
            if (gd.CurrentState != MdGlobal.GameData.CurrentState)
            {
                hasChanged = true;
            }
            MdGlobal.GameData = gd;
            Console.WriteLine("Client update GameData from Server with state " + gd.CurrentState.ToString());
            MdUI.MainForm.SetLStatus(gd.CurrentStatus);
            
            if (hasChanged)
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
        

        public static void SendJoinGameRequest()
        {
            SRHub.Invoke("RequestJoinGame", MdGlobal.Nickname);
        }

        public static void SendHand(int hand)
        {
            SRHub.Invoke("SendHand", hand, MdGlobal.PlayerID);
        }


    }
}
