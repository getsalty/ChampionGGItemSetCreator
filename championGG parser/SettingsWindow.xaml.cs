using System;
using System.Windows;
using System.Windows.Forms;

namespace championGG_parser
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            directoryPathTextBox.Text = Properties.Settings.Default["OutputDirectory"].ToString();
            mostPopularBuild.IsChecked = Convert.ToBoolean(Properties.Settings.Default["UsePopularItems"].ToString());
            highestWinRateBuild.IsChecked = Convert.ToBoolean(Properties.Settings.Default["UseMostWinItems"].ToString());



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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            directoryPathTextBox.Text = fbd.SelectedPath;
        }

        private void buttonSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default["OutputDirectory"] = directoryPathTextBox.Text;
            Properties.Settings.Default["UsePopularItems"] = mostPopularBuild.IsChecked;
            Properties.Settings.Default["UseMostWinItems"] = highestWinRateBuild.IsChecked;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
