using System;
using System.Collections.Generic;
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
    /// Interaction logic for SystemManagerControl.xaml
    /// </summary>
    public partial class SystemManagerControl : UserControl
    {
        public SystemManagerControl()
        {
            InitializeComponent();
        }

        private void Exit_OnClick(object sender, RoutedEventArgs e) {
            ((MainWindow) System.Windows.Application.Current.MainWindow).EnableExit = true;
            Application.Current.Shutdown();
        }

        private void Back_OnClick(object sender, RoutedEventArgs e) {
            ControlNavigator.SetContentController(ControlNavigator.FrontPage());
        }

        private void DatabaseManager_OnClick(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }

        private void AddStudent_OnClick(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }
    }
}
