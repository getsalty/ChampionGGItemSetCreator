using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace championGG_parser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChampionList ch;


        public MainWindow()
        {
            Helper.LoadItems();

            ch = new ChampionList();
            ch.LoadChampions();


            InitializeComponent();
            listbox1.ItemsSource = ch.champions;
        }

        private void ParserButton_Click(object sender, RoutedEventArgs e)
        {
            string folderName = Properties.Settings.Default["OutputDirectory"].ToString();
            System.IO.Directory.CreateDirectory(folderName);
            string pathString = System.IO.Path.Combine(folderName, "Config");
            System.IO.Directory.CreateDirectory(pathString);
            string pathString2 = System.IO.Path.Combine(pathString, "Champions");
            System.IO.Directory.CreateDirectory(pathString2);

            foreach (var item in ch.champions)
            {
                string pathString3 = System.IO.Path.Combine(pathString2, item.name);
                System.IO.Directory.CreateDirectory(pathString3);
                string pathString4 = System.IO.Path.Combine(pathString3, "Recommended");
                System.IO.Directory.CreateDirectory(pathString4);


                foreach (var item2 in item.positions)
                {
                    string fileName = item.name + "_" + item2.name + "_" + item2.patch.Replace(".", "_") + ".json";
                    string pathString5 = System.IO.Path.Combine(pathString4, fileName);

                    using (StreamWriter outfile = new StreamWriter(pathString5))
                    {
                        outfile.Write(item2.CreateOutputString(item.name));
                    }
                }
            }

            checkmarkImage.Visibility = Visibility.Visible;
            Thread thread1 = new Thread(() =>
            {
                Thread.Sleep(800);
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    checkmarkImage.Visibility = Visibility.Hidden;
                }));
            });
            thread1.Start();
        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox tmpListBox = sender as ListBox;
            Champion tmpChamp = tmpListBox.SelectedItem as Champion;
            itemSet2.ItemsSource = tmpChamp.positions;

        }

        private void buttonGetData_Click(object sender, RoutedEventArgs e)
        {
            loadingGif.Visibility = Visibility.Visible;
            dataLoadingBarForeground.Visibility = Visibility.Visible;
            dataLoadingBarBackground.Visibility = Visibility.Visible;
            buttonGetData.IsEnabled = false;

            Thread thread1 = new Thread(() =>
            {
                foreach (var item in ch.champions)
                {
                    foreach (var item2 in item.positions)
                    {
                        item2.website.URL = "http://champion.gg/champion/" + item.name + "/" + item2.name;
                        item2.PopulateItems();
                    }
                    Application.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        dataLoadingBarForeground.Width++;
                    }));
                }
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    loadingGif.Visibility = Visibility.Hidden;
                    dataLoadingBarForeground.Visibility = Visibility.Hidden;
                    dataLoadingBarBackground.Visibility = Visibility.Hidden;
                    dropdownClearHTML.IsEnabled = true;
                    dropdownExportFiles.IsEnabled = true;
                    ParserButton.IsEnabled = true;
                    buttonGetData.IsEnabled = true;
                    buttonClearTextHTML.IsEnabled = true;
                    itemSet.Items.Refresh();
                }));

            });
            thread1.Start();
        }

        private void loadingGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            loadingGif.Position = TimeSpan.FromMilliseconds(1);
        }

        private void buttonClearTextHTML_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in ch.champions)
            {
                foreach (var item2 in item.positions)
                {
                    item2.website.textHTML = "";
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            sw.Show();
            sw.ChangeWindowLocation(this.ActualWidth, this.ActualHeight, this.Left, this.Top);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void itemSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.Write(itemSet);
        }


    }
}
