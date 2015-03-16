//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

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
