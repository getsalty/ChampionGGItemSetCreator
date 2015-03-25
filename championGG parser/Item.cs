//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

namespace championGG_parser
{
    public class Item
    {
        private short _id;
        private string _name;
        private string _img;

        /// <summary>
        /// Id of the item.
        /// </summary>
        public short id
        {
            get { return _id; }
            set
            {
                _id = value;
                _img = "Resources/Item Images/" + value + ".png";
            }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string img
        {
            get { return _img; }
        }
    }
}
