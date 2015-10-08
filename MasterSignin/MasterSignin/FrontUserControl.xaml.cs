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
    /// Interaction logic for FrontUserControl.xaml
    /// </summary>
    public partial class FrontUserControl : UserControl
    {
        public FrontUserControl()
        {
            InitializeComponent();
        }

        private void SignIn_OnClick(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }

        private void SystemManagement_OnClick(object sender, RoutedEventArgs e) {
            ControlNavigator.SetContentController(ControlNavigator.SystemManager());
        }

        private void SignOut_OnClick(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }
    }
}
