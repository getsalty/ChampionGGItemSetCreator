﻿//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace championGG_parser
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region Variables

        #region Private Variables
        private ICommand _command_GetData;
        private ICommand _command_ExportData;
        private ICommand _command_DeleteItemSets;
        private ICommand _command_ClearHTML;

        private Visibility _vis_LoadingGif;
        private Visibility _vis_DataLoadingBarForeground;
        private Visibility _vis_DataLoadingBarBackground;
        private Visibility _vis_CheckMark;
        private Visibility _vis_UpdateDataLabel;

        private bool _enable_Button_GetData;
        private bool _enable_Button_Export;
        private bool _enable_Button_DeletePrev;
        private bool _enable_DropDown_ClearHTML;
        private bool _enable_DropDown_ExportFiles;
        private bool _enable_DropDown_GetData;

        private int _selectedIndex;
        private int _width_DataLoadingBarForeground;
        private List<Position> _positionSource;
        private ChampionList _championList;

        #endregion

        #region Public Wrappers

        public ChampionList ChampionList
        {
            get { return _championList; }
            set
            {
                _championList = value;
                OnPropertyChanged();
            }
        }
        public int Width_DataLoadingBarForeground
        {
            get { return _width_DataLoadingBarForeground; }
            set
            {
                _width_DataLoadingBarForeground = value;
                OnPropertyChanged();
            }
        }


        #region Visibility Variables
        public Visibility Vis_LoadingGif
        {
            get { return _vis_LoadingGif; }
            set
            {
                _vis_LoadingGif = value;
                OnPropertyChanged();
            }
        }
        public Visibility Vis_DataLoadingBarForeground
        {
            get { return _vis_DataLoadingBarForeground; }
            set
            {
                _vis_DataLoadingBarForeground = value;
                OnPropertyChanged();
            }
        }
        public Visibility Vis_DataLoadingBarBackground
        {
            get { return _vis_DataLoadingBarBackground; }
            set
            {
                _vis_DataLoadingBarBackground = value;
                OnPropertyChanged();
            }
        }
        public Visibility Vis_CheckMark
        {
            get { return _vis_CheckMark; }
            set
            {
                _vis_CheckMark = value;
                OnPropertyChanged();
            }
        }
        public Visibility Vis_UpdateDataLabel
        {
            get { return _vis_UpdateDataLabel; }
            set
            {
                _vis_UpdateDataLabel = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Enable Variables
        public bool Enable_Button_GetData
        {
            get { return _enable_Button_GetData; }
            set
            {
                _enable_Button_GetData = value;
                OnPropertyChanged();
            }
        }
        public bool Enable_Button_Export
        {
            get { return _enable_Button_Export; }
            set
            {
                _enable_Button_Export = value;
                OnPropertyChanged();
            }
        }
        public bool Enable_Button_DeletePrev
        {
            get { return _enable_Button_DeletePrev; }
            set
            {
                _enable_Button_DeletePrev = value;
                OnPropertyChanged();
            }
        }
        public bool Enable_DropDown_ClearHTML
        {
            get { return _enable_DropDown_ClearHTML; }
            set
            {
                _enable_DropDown_ClearHTML = value;
                OnPropertyChanged();
            }
        }
        public bool Enable_DropDown_ExportFiles
        {
            get { return _enable_DropDown_ExportFiles; }
            set
            {
                _enable_DropDown_ExportFiles = value;
                OnPropertyChanged();
            }
        }
        public bool Enable_DropDown_GetData
        {
            get { return _enable_DropDown_GetData; }
            set
            {
                _enable_DropDown_GetData = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Command Variables
        public ICommand Command_GetData
        {
            get
            {
                if (_command_GetData == null)
                {
                    _command_GetData = new DelegateCommand(GetData);
                }
                return _command_GetData;
            }
        }
        public ICommand Command_ExportData
        {
            get
            {
                if (_command_ExportData == null)
                {
                    _command_ExportData = new DelegateCommand(ExportData);
                }
                return _command_ExportData;
            }
        }
        public ICommand Command_DeleteItemSets
        {
            get
            {
                if (_command_DeleteItemSets == null)
                {
                    _command_DeleteItemSets = new DelegateCommand(DeleteItemSets);
                }
                return _command_DeleteItemSets;
            }
        }
        public ICommand Command_ClearHTML
        {
            get
            {
                if (_command_ClearHTML == null)
                {
                    _command_ClearHTML = new DelegateCommand(ClearHTML);
                }
                return _command_ClearHTML;
            }
        }
        #endregion

        #endregion

        #endregion

        public MainViewModel()
        {
            bool enableItems = false;
            ChampionList = new ChampionList(ref enableItems);
            Vis_LoadingGif = Visibility.Hidden;
            Vis_DataLoadingBarForeground = Visibility.Hidden;
            Vis_DataLoadingBarBackground = Visibility.Hidden;
            Vis_CheckMark = Visibility.Hidden;
            Vis_UpdateDataLabel = enableItems ? Visibility.Hidden : Visibility.Visible;
            Enable_Button_GetData = true;
            Enable_Button_Export = enableItems ? true : false;
            Enable_Button_DeletePrev = enableItems ? true : false;
            Enable_DropDown_ClearHTML = false;
            Enable_DropDown_ExportFiles = enableItems ? true : false;
            Enable_DropDown_GetData = true;
            Width_DataLoadingBarForeground = 0;
            UpdateGUIChampion();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void GetData()
        {
            Vis_LoadingGif = Visibility.Visible;
            Vis_DataLoadingBarForeground = Visibility.Visible;
            Vis_DataLoadingBarBackground = Visibility.Visible;
            Vis_UpdateDataLabel = Visibility.Hidden;
            Enable_Button_GetData = false;
            Enable_Button_Export = false;
            Enable_Button_DeletePrev = false;
            Enable_DropDown_GetData = false;
            Enable_DropDown_ExportFiles = false;
            Enable_DropDown_ClearHTML = false;

            Thread thread1 = new Thread(() =>
            {
                Website tmpWeb = new Website("http://champion.gg/");
                string tmpStr = tmpWeb.textHTML;
                string[] splitValues = Helper.StringBetween(ref tmpStr, "col-md-9", "col-md-3", true).Split('\n');

                foreach (var champion in ChampionList.champions)
                {
                    champion.positions.Clear();
                    string championString = "/champion/" + champion.name.ToLower() + "/";
                    var positionStrings = splitValues.Where(i => i.Contains(championString));
                    foreach (var posStr in positionStrings)
                    {
                        if (posStr.Contains("top"))
                        {
                            champion.positions.Add(new Position(Helper.Top));
                        }
                        else if (posStr.Contains("jungle"))
                        {
                            champion.positions.Add(new Position(Helper.Jungle));
                        }
                        else if (posStr.Contains("middle"))
                        {
                            champion.positions.Add(new Position(Helper.Middle));
                        }
                        else if (posStr.Contains("adc"))
                        {
                            champion.positions.Add(new Position(Helper.ADC));
                        }
                        else if (posStr.Contains("support"))
                        {
                            champion.positions.Add(new Position(Helper.Support));
                        }
                    }
                }

                int Curr_Champion = 0;
                foreach (var champion in ChampionList.champions)
                {
                    foreach (var position in champion.positions)
                    {
                        position.website.URL = "http://champion.gg/champion/" + champion.name + "/" + position.name;
                        position.PopulateItems();
                        position.website.textHTML = "";
                    }
                    Curr_Champion++;
                    Width_DataLoadingBarForeground = Convert.ToInt32((124 * ((float)Curr_Champion / (float)ChampionList.champions.Count)));
                }

                Vis_LoadingGif = Visibility.Hidden;
                Vis_DataLoadingBarForeground = Visibility.Hidden;
                Vis_DataLoadingBarBackground = Visibility.Hidden;
                Width_DataLoadingBarForeground = 0;
                Enable_Button_GetData = true;
                Enable_Button_Export = true;
                Enable_Button_DeletePrev = true;
                Enable_DropDown_ClearHTML = true;
                Enable_DropDown_ExportFiles = true;
                Enable_DropDown_GetData = true;

                string json = JsonConvert.SerializeObject(ChampionList, Formatting.Indented);

                using (StreamWriter outfile = new StreamWriter(@".\Resources\championData.json"))
                {
                    outfile.Write(json);
                }

            });
            thread1.IsBackground = true;
            thread1.Start();
        }

        private void ExportData()
        {
            string outputDirectory = Properties.Settings.Default["OutputDirectory"].ToString();
            System.IO.Directory.CreateDirectory(outputDirectory);
            string configDirectory = System.IO.Path.Combine(outputDirectory, "Config");
            System.IO.Directory.CreateDirectory(configDirectory);
            string championsDirectory = System.IO.Path.Combine(configDirectory, "Champions");
            System.IO.Directory.CreateDirectory(championsDirectory);

            foreach (var item in ChampionList.champions)
            {
                string champDirectory = System.IO.Path.Combine(championsDirectory, item.name);
                System.IO.Directory.CreateDirectory(champDirectory);
                string recommendedDirectory = System.IO.Path.Combine(champDirectory, "Recommended");
                System.IO.Directory.CreateDirectory(recommendedDirectory);

                foreach (var item2 in item.positions)
                {
                    string fileName = item.name + "_" + item2.name + "_" + item2.patch.Replace(".", "_") + ".json";
                    string outputPath = System.IO.Path.Combine(recommendedDirectory, fileName);

                    using (StreamWriter outfile = new StreamWriter(outputPath))
                    {
                        outfile.Write(item2.CreateOutputString(item.name));
                    }
                }
            }

            Vis_CheckMark = Visibility.Visible;
            Thread thread1 = new Thread(() =>
            {
                Thread.Sleep(800);
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    Vis_CheckMark = Visibility.Hidden;
                }));
            });
            thread1.IsBackground = true;
            thread1.Start();

        }

        private void DeleteItemSets()
        {
            string outputDirectory = Properties.Settings.Default["OutputDirectory"].ToString();
            System.IO.Directory.CreateDirectory(outputDirectory);
            string configDirectory = System.IO.Path.Combine(outputDirectory, "Config");
            System.IO.Directory.CreateDirectory(configDirectory);
            string championsDirectory = System.IO.Path.Combine(configDirectory, "Champions");
            System.IO.Directory.CreateDirectory(championsDirectory);

            foreach (var item in ChampionList.champions)
            {
                string champDirectory = System.IO.Path.Combine(championsDirectory, item.name);
                System.IO.Directory.CreateDirectory(champDirectory);
                string recommendedDirectory = System.IO.Path.Combine(champDirectory, "Recommended");
                System.IO.Directory.CreateDirectory(recommendedDirectory);


                var contains = Directory.EnumerateFiles(recommendedDirectory).Where(f => f.Contains("_6_"));
                foreach (var item2 in contains)
                {
                    File.Delete(item2);
                }
            }

            Vis_CheckMark = Visibility.Visible;
            Thread thread1 = new Thread(() =>
            {
                Thread.Sleep(800);
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    Vis_CheckMark = Visibility.Hidden;
                }));
            });
            thread1.IsBackground = true;
            thread1.Start();
        }

        private void ClearHTML()
        {
            foreach (var champ in ChampionList.champions)
            {
                foreach (var pos in champ.positions)
                {
                    pos.website.textHTML = "";
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }

            set
            {
                if (_selectedIndex == value)
                {
                    return;
                }
                _selectedIndex = value;
                UpdateGUIChampion();
                OnPropertyChanged();
            }
        }

        public List<Position> PositionSource
        {
            get { return _positionSource; }
            set
            {
                _positionSource = value;
                OnPropertyChanged();
            }
        }

        public void UpdateGUIChampion()
        {
            Champion tmpChamp = ChampionList.champions[SelectedIndex];
            PositionSource = tmpChamp.positions;
        }

    }
}
