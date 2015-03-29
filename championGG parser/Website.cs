//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

using System.Net;
using System.Text.RegularExpressions;

namespace championGG_parser
{
    public class Website
    {
        #region variables
        private string _URL;

        public string URL
        {
            get
            {
                return _URL;
            }
            set
            {
                _URL = value;
                LoadWebsite();
            }
        }

        public string textHTML
        {
            get;
            set;
        }
        #endregion

        #region constructors
        public Website(string URL)
        {
            this.URL = URL;
            LoadWebsite();

        }

        public Website() { }
        #endregion

        #region functions
        /// <summary>
        /// Loads the website and stores the html into "textHTML" as a string.
        /// </summary>
        void LoadWebsite()
        {
            WebClient wc = new WebClient();
            textHTML = wc.DownloadString(URL).Replace(" ", "").ToLower();
        }
        #endregion
    }
}
