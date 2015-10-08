using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterSignin
{
    /// <summary>
    /// User control handeler. 
    /// </summary>
    public static class ControlNavigator
    {
        public static object FrontPage() { return new FrontUserControl();}
        public static object SystemManager() { return new SystemManagerControl();}

        public static void SetContentController(object controller) {
            ((MainWindow) System.Windows.Application.Current.MainWindow).ContentController = controller;
        }
    }
}
