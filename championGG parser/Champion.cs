//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.



using System.Collections.Generic;

namespace championGG_parser
{
    public class Champion
    {
        #region variables
        public List<Position> positions;
        public string name
        {
            get;
            private set;
        }
        #endregion

        #region constructors
        public Champion(string name, string[] positions)
            : this(name)
        {
            foreach (var item in positions)
            {
                this.positions.Add(new Position(item));
            }
        }

        public Champion(string name)
        {
            this.positions = new List<Position>();
            this.name = name;
        }
        #endregion
    }
}
