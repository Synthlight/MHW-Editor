using System.Windows;

namespace MHW_Editor {
    public partial class App {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            EncryptionHelper.DecryptFiles();
        }
    }
}