using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterSignin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            #region kill Explorer
            //Start a command line stream to kill explorer.exe via hidden command line.
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C taskkill /F /IM explorer.exe"
            };
            process.StartInfo = startInfo;
            //While you could do Process.kill("explorer.exe");, windows NT systems will auto restart the explorer.
            //Using shell fixs the shell restart.
            process.Start();
            #endregion

        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            #region start Explorer
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C explorer.exe"
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit(200);
            #endregion

        }
    }
}
