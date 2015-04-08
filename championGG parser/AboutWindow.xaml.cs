using System;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;

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

            Assembly thisAssem = typeof(MainWindow).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();
            Version ver = thisAssemName.Version;
            Version.Text = ver.ToString();
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
