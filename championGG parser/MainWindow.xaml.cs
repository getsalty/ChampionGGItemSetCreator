//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

using System;
using System.Windows;
using System.Windows.Controls;

namespace championGG_parser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Helper.LoadItems();
            InitializeComponent();
        }

        /// <summary>
        /// Repeats the Gif indefinitly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadingGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            loadingGif.Position = TimeSpan.FromMilliseconds(1);
        }

        /// <summary>
        /// Shows the settings menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSettingsWindow(object sender, RoutedEventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            sw.ChangeWindowLocation(this.ActualWidth, this.ActualHeight, this.Left, this.Top);
            sw.Show();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShutdownApplication(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Shows the about window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAboutWindow(object sender, RoutedEventArgs e)
        {
            AboutWindow sw = new AboutWindow();
            sw.ChangeWindowLocation(this.ActualWidth, this.ActualHeight, this.Left, this.Top);
            sw.Show();
        }

        /// <summary>
        /// Shows the tooltips for the hovered item image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowToolTips(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Image test = sender as Image;
            foreach (var item in Helper.gameItems)
            {
                if (test.Source.ToString().Contains(item.Key.ToString()))
                {
                    test.ToolTip = item.Value;
                    return;
                }
            }
        }

    }
}
