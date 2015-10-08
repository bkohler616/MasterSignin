using System.ComponentModel;
using System.Windows;

namespace MasterSignin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object ContentController {set { ContentControl.Content = value; } }

        public bool EnableExit = false;

        public MainWindow() {
            InitializeComponent();

            #region kill Explorer

            //Start a command line stream to kill explorer.exe via hidden command line.
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C taskkill /F /IM explorer.exe"
            };
            process.StartInfo = startInfo;
            //While you could do Process.kill("explorer.exe");, windows NT systems will auto restart the explorer.
            //Using shell fixs the shell restart.
            process.Start();

            #endregion

            //Setup main view
            ControlNavigator.SetContentController(ControlNavigator.FrontPage());
            ContentController = ControlNavigator.FrontPage();
        }


        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            if (EnableExit) {
                #region start Explorer

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C explorer.exe"
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit(200);

                #endregion
            }
            else {
                e.Cancel = true;
            }

        }


    }
}
