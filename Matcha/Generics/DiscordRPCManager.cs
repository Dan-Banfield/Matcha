using DiscordRPC;
using System;

namespace Matcha.Generics
{
    public class DiscordRPCManager
    {
        private string applicationID = "963719187845513216";

        private DiscordRpcClient discordRpcClient;

        public DiscordRPCManager(string applicationID)
        {
            InitializeDiscordRPC();
        }

        private void InitializeDiscordRPC()
        {
            discordRpcClient = new DiscordRpcClient(applicationID);
            discordRpcClient.Initialize();
        }

        public void UpdateStatus(string details)
        {
            //TODO: Update this code when building an official release.

            discordRpcClient.SetPresence(new RichPresence() 
            {
                Details = details,

                Timestamps = new Timestamps()
                {
                    Start = DateTime.UtcNow
                },

                Buttons = new Button[]
                {
                    new Button() { Label = "Interested?", Url = "https://discord.gg/rakMEdSUN6" }
                },

                Assets = new Assets() 
                {
                    LargeImageKey = "big",
                    LargeImageText = "Matcha"
                }
            });
        }
    }
}
