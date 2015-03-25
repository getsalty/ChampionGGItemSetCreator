using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace championGG_parser
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.ToString());
        }
        public void ChangeWindowLocation(double mainWindowWidth, double mainWindowHeight, double mainWindowLeft, double mainWindowTop)
        {
            double screenWidth = mainWindowWidth;
            double screenHeight = mainWindowHeight;
            double windowWidth = this.ActualWidth;
            double windowHeight = this.ActualHeight;
            this.Left = (screenWidth / 2) - (windowWidth / 2) + mainWindowLeft;
            this.Top = (screenHeight / 2) - (windowHeight / 2) + mainWindowTop;
        }
    }
}
