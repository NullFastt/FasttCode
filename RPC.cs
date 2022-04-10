using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using DiscordRPC.Message;

namespace FasttCode
{
    internal class RPC
    {
        public static DiscordRpcClient Client { get; set; }

        private static RichPresence _currentPresence;

        private static readonly Assets _assets = new Assets
        {
            LargeImageKey = "logo",
            LargeImageText = "Fastt Code by HugoFastt"
        };

        private static readonly Timestamps _timestamps = new Timestamps
        {
            StartUnixMilliseconds = (ulong)DateTimeOffset.Now.ToUnixTimeSeconds()
        };


    private static readonly Button[] _buttons =
        {
            new Button
            {
                Label = "Unete al Disvord",
                Url = "https://discord.gg/CyuRNuxNWz"
            },
            new Button
            {
                Label = "¿Necesitas ayuda?",
                Url = "https://discord.gg/N58cy7HfFB"
            }
        };

        
        public static void Start()
        {

            Client = new DiscordRpcClient("960987791242707015");

            _currentPresence = new RichPresence
            {
                Details = "Maded by HugoFastt",
                State = "Usando FasttCode",
                Assets = _assets,
                Buttons = _buttons,
                Timestamps = _timestamps
            };

            Client.SetPresence(_currentPresence);
            Client.Initialize();
            Client.OnReady += delegate (object sender, ReadyMessage e)
            {
                Form1.Username = e.User.Username;
                Form1.hastag = e.User.Discriminator.ToString();

            };
        }
    }
}

