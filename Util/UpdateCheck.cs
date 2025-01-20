using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using JetBrains.Annotations;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using Newtonsoft.Json;

// Separate because `using System.Windows.Forms;` in an xaml class causes ReSharper to imagine annoying problems.
namespace MHW_Editor.Util {
    public static class UpdateCheck {
        private const string NEXUS_LINK = "https://www.nexusmods.com/monsterhunterworld/mods/2068";
        public static bool SingleClick_Mode = true;

        [CanBeNull] public static NotifyIcon notifyIcon;

        public static async void Run(MainWindow mainWindow) {
            await Task.Run(() => {
                try {
                    var json           = GetHttpText("http://brutsches.com/MHW-Editor.version.json");
                    var currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    var newestVersion  = JsonConvert.DeserializeObject<VersionCheck>(json).latest;

                    if (currentVersion != newestVersion) {
                        mainWindow.Dispatcher?.InvokeAsync(() => {
                            notifyIcon = new NotifyIcon {
                                Icon    = SystemIcons.Application,
                                Visible = false,
                                Text = "MHW Editor\r\n" +
                                       "Update Available.\r\n" +
                                       "Click to go to the mod page."
                            };
                            //notifyIcon.BalloonTipClosed += (s, e) => notifyIcon.Visible = false;
                            notifyIcon.MouseClick += (sender, args) => { Process.Start(NEXUS_LINK); };

                            notifyIcon.Visible = true;
                            notifyIcon.ShowBalloonTip(10000, "Update Available", "A newer version has been detected.\r\n" +
                                                                                 $"Your Version: {currentVersion}\r\n" +
                                                                                 $"Newer Version: {newestVersion}", ToolTipIcon.Info);
                        });
                    }
                } catch (Exception e) {
                    Console.Error.Write(e);
                }
            });
        }

        private static string GetHttpText(string url) {
            var request = (HttpWebRequest) WebRequest.Create(url);
            request.Method = "GET";

            using var response = (HttpWebResponse) request.GetResponse();
            using var reader   = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException());
            return reader.ReadToEnd();
        }
    }
}