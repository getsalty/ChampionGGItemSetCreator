//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace championGG_parser
{
    class Position
    {
        public List<Item> popularItemList { get; set; }
        public List<Item> highestWinItemList { get; set; }
        public List<Item> popularStarterList { get; set; }
        public List<Item> highestWinStarterList { get; set; }
        public Website website;
        public string patch
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }

        #region constructors
        public Position(string name)
        {
            popularItemList = new List<Item>();
            highestWinItemList = new List<Item>();
            popularStarterList = new List<Item>();
            highestWinStarterList = new List<Item>();
            website = new Website();
            this.name = name;
        }

        public Position()
        {
            popularItemList = new List<Item>();
            highestWinItemList = new List<Item>();
            popularStarterList = new List<Item>();
            highestWinStarterList = new List<Item>();
            website = new Website();
            this.name = "";
        }
        #endregion

        #region functions
        /// <summary>
        /// Creates the data for an output file.
        /// </summary>
        /// <param name="_name">Champion Name</param>
        /// <returns></returns>
        public string CreateOutputString(string _name)
        {
            string output = "";

            output += "{" + System.Environment.NewLine + "";
            output += "   \"map\": \"any\"," + System.Environment.NewLine + "";
            output += "   \"isGlobalForChampions\": false," + System.Environment.NewLine + "";
            output += "   \"blocks\": [" + System.Environment.NewLine + "";

            #region popular starters
            if (Convert.ToBoolean(Properties.Settings.Default["UsePopularItems"].ToString()))
            {
                output += "       {" + System.Environment.NewLine + "";
                output += "           \"items\": [" + System.Environment.NewLine + "";

                var countedItems = popularStarterList.GroupBy(o => o.id)
                    .Select(c => new
                    {
                        Id = c.Key,
                        Count = c.Count()
                    });

                foreach (var item in countedItems)
                {
                    output += "               { \"count\": " + item.Count + ", \"id\": \"" + item.Id + "\" }," + System.Environment.NewLine + "";
                }

                output += "               { \"count\": 1, \"id\": \"3340\" }" + System.Environment.NewLine + "";
                output += "           ]," + System.Environment.NewLine + "";
                output += "           \"type\": \"Popular Starters\"" + System.Environment.NewLine + "";
                output += "       }," + System.Environment.NewLine + "";
            }
            #endregion

            #region highest win starters
            if (Convert.ToBoolean(Properties.Settings.Default["UseMostWinItems"].ToString()))
            {
                output += "       {" + System.Environment.NewLine + "";
                output += "           \"items\": [" + System.Environment.NewLine + "";


                var countedItems = highestWinStarterList.GroupBy(o => o.id)
                    .Select(c => new
                    {
                        Id = c.Key,
                        Count = c.Count()
                    });

                foreach (var item in countedItems)
                {
                    output += "               { \"count\": " + item.Count + ", \"id\": \"" + item.Id + "\" }," + System.Environment.NewLine + "";
                }

                output += "               { \"count\": 1, \"id\": \"3340\" }" + System.Environment.NewLine + "";
                output += "           ]," + System.Environment.NewLine + "";
                output += "           \"type\": \"Highest Win Rate Starters\"" + System.Environment.NewLine + "";
                output += "       }," + System.Environment.NewLine + "";
            }
            #endregion

            #region popular items
            if (Convert.ToBoolean(Properties.Settings.Default["UsePopularItems"].ToString()))
            {
                output += "       {" + System.Environment.NewLine + "";
                output += "           \"items\": [" + System.Environment.NewLine + "";

                var countedItems = popularItemList.GroupBy(o => o.id)
                    .Select(c => new
                    {
                        Id = c.Key,
                        Count = c.Count()
                    });

                for (int i = 0; i < countedItems.Count(); i++)
                {
                    short id = countedItems.ElementAt(i).Id;
                    int count = countedItems.ElementAt(i).Count;

                    if (i != countedItems.Count() - 1)
                    {
                        output += "               { \"count\": " + count + ", \"id\": \"" + id + "\" }," + System.Environment.NewLine + "";
                    }
                    else
                    {
                        output += "               { \"count\": " + count + ", \"id\": \"" + id + "\" }" + System.Environment.NewLine + "";
                    }
                }

                output += "           ]," + System.Environment.NewLine + "";
                output += "           \"type\": \"Popular Items\"" + System.Environment.NewLine + "";
                output += "       }," + System.Environment.NewLine + "";

            }
            #endregion

            #region highest win items
            if (Convert.ToBoolean(Properties.Settings.Default["UseMostWinItems"].ToString()))
            {
                output += "       {" + System.Environment.NewLine + "";
                output += "           \"items\": [" + System.Environment.NewLine + "";

                var countedItems = highestWinItemList.GroupBy(o => o.id)
                    .Select(c => new
                    {
                        Id = c.Key,
                        Count = c.Count()
                    });

                for (int i = 0; i < countedItems.Count(); i++)
                {
                    short id = countedItems.ElementAt(i).Id;
                    int count = countedItems.ElementAt(i).Count;

                    if (i != countedItems.Count() - 1)
                    {
                        output += "               { \"count\": " + count + ", \"id\": \"" + id + "\" }," + System.Environment.NewLine + "";
                    }
                    else
                    {
                        output += "               { \"count\": " + count + ", \"id\": \"" + id + "\" }" + System.Environment.NewLine + "";
                    }
                }

                output += "           ]," + System.Environment.NewLine + "";
                output += "           \"type\": \"Highest Win Rate Items\"" + System.Environment.NewLine + "";
                output += "       }," + System.Environment.NewLine + "";
            }
            #endregion

            #region consumables
            output += "       {" + System.Environment.NewLine + "";
            output += "           \"items\": [" + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2003\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2004\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2137\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2138\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2139\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2140\" }" + System.Environment.NewLine + "";
            output += "           ]," + System.Environment.NewLine + "";
            output += "           \"type\": \"Consumables\"" + System.Environment.NewLine + "";
            output += "       }," + System.Environment.NewLine + "";
            #endregion

            #region vision
            output += "       {" + System.Environment.NewLine + "";
            output += "           \"items\": [" + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2044\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"2043\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"3340\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"3341\" }," + System.Environment.NewLine + "";
            output += "               { \"count\": 1, \"id\": \"3342\" }" + System.Environment.NewLine + "";
            output += "           ]," + System.Environment.NewLine + "";
            output += "           \"type\": \"Vision\"" + System.Environment.NewLine + "";
            output += "       }" + System.Environment.NewLine + "";
            #endregion

            output += "   ]," + System.Environment.NewLine + "";
            output += "   \"associatedChampions\": [ ]," + System.Environment.NewLine + "";
            output += "   \"title\": \"" + name + " " + patch + "\"," + System.Environment.NewLine + "";
            output += "   \"priority\": false," + System.Environment.NewLine + "";
            output += "   \"mode\": \"any\"," + System.Environment.NewLine + "";
            output += "   \"isGlobalForMaps\": true," + System.Environment.NewLine + "";
            output += "   \"associatedMaps\": [ ]," + System.Environment.NewLine + "";
            output += "   \"type\": \"custom\"," + System.Environment.NewLine + "";
            output += "   \"sortrank\": 1," + System.Environment.NewLine + "";
            output += "   \"champion\": \"" + _name + "\"" + System.Environment.NewLine + "";
            output += "}" + System.Environment.NewLine + "";

            return output;
        }

        /// <summary>
        /// Prints the Items out to the Debug Console
        /// </summary>
        /// <param name="_name">Champion Name</param>
        public void PrintItems(string _name)
        {
            Debug.WriteLine("{");
            Debug.WriteLine("   \"map\": \"any\",");
            Debug.WriteLine("   \"isGlobalForChampions\": false,");
            Debug.WriteLine("   \"blocks\": [");

            #region popular starters
            Debug.WriteLine("       {");
            Debug.WriteLine("           \"items\": [");

            for (int i = 0; i < popularStarterList.Count; i++)
            {
                if (i != popularStarterList.Count - 1)
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + popularStarterList[i].id + "\" },");
                }
                else
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + popularStarterList[i].id + "\" }");
                }
            }

            Debug.WriteLine("           ],");
            Debug.WriteLine("           \"type\": \"Popular Starters\"");
            Debug.WriteLine("       },");
            #endregion

            #region highest win starters
            Debug.WriteLine("       {");
            Debug.WriteLine("           \"items\": [");

            for (int i = 0; i < highestWinStarterList.Count; i++)
            {
                if (i != highestWinStarterList.Count - 1)
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + highestWinStarterList[i].id + "\" },");
                }
                else
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + highestWinStarterList[i].id + "\" }");
                }
            }

            Debug.WriteLine("           ],");
            Debug.WriteLine("           \"type\": \"Highest Win Rate Starters\"");
            Debug.WriteLine("       },");
            #endregion

            #region popular items
            Debug.WriteLine("       {");
            Debug.WriteLine("           \"items\": [");

            for (int i = 0; i < popularItemList.Count; i++)
            {
                if (i != popularItemList.Count - 1)
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + popularItemList[i].id + "\" },");
                }
                else
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + popularItemList[i].id + "\" }");
                }
            }

            Debug.WriteLine("           ],");
            Debug.WriteLine("           \"type\": \"Popular Items\"");
            Debug.WriteLine("       },");
            #endregion

            #region highest win items
            Debug.WriteLine("       {");
            Debug.WriteLine("           \"items\": [");

            for (int i = 0; i < highestWinItemList.Count; i++)
            {
                if (i != highestWinItemList.Count - 1)
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + highestWinItemList[i].id + "\" },");
                }
                else
                {
                    Debug.WriteLine("               { \"count\": 1, \"id\": \"" + highestWinItemList[i].id + "\" }");
                }
            }

            Debug.WriteLine("           ],");
            Debug.WriteLine("           \"type\": \"Highest Win Rate Items\"");
            Debug.WriteLine("       }");
            #endregion

            Debug.WriteLine("   ],");
            Debug.WriteLine("   \"associatedChampions\": [ ],");
            Debug.WriteLine("   \"title\": \"" + name + " " + patch + "\",");
            Debug.WriteLine("   \"priority\": false,");
            Debug.WriteLine("   \"mode\": \"any\",");
            Debug.WriteLine("   \"isGlobalForMaps\": true,");
            Debug.WriteLine("   \"associatedMaps\": [ ],");
            Debug.WriteLine("   \"type\": \"custom\",");
            Debug.WriteLine("   \"sortrank\": 1,");
            Debug.WriteLine("   \"champion\": \"" + _name + "\"");
            Debug.WriteLine("}");
        }

        /// <summary>
        /// Populates the given list with items in the source located between "from" and "to".
        /// </summary>
        /// <param name="source">The source that will be parsed.</param>
        /// <param name="from">The starting point of where to parse.</param>
        /// <param name="to">The ending point of where to parse.</param>
        /// <param name="itemList">The list in which the items will be stored.</param>
        void PopulateIndividualList(string source, string from, string to, List<Item> itemList)
        {
            string[] splitValues = Helper.StringBetween(source, from, to).Split('\n');

            foreach (var item in splitValues)
            {
                string findFrom = ("/img/item/").ToLower();
                string findTo = (".png").ToLower();
                string itemID = Helper.StringBetween(item, findFrom, findTo);
                if (itemID != "")
                {
                    if (itemID == "2010")
                    {
                        itemID = "2003";
                    }
                    short tmpID = Convert.ToInt16(itemID);
                    itemList.Add(new Item() { id = tmpID, name = Helper.gameItems[tmpID] });
                }
            }
        }

        /// <summary>
        /// Populates each of the four lists.
        /// </summary>
        public void PopulateItems()
        {
            string findFrom = ("<h2 class=\"champion-stats\">Most Frequent Core Build</h2>").ToLower();
            string findTo = ("<h2 class=\"champion-stats\"  style=\"margin-top:40px\">Highest Win % Core Build</h2>").ToLower();
            PopulateIndividualList(website.textHTML, findFrom, findTo, popularItemList);

            findFrom = ("<h2 class=\"champion-stats\"  style=\"margin-top:40px\">Highest Win % Core Build</h2>").ToLower();
            findTo = ("<div class=\"col-xs-12 col-sm-12 col-md-5 counter-column\">").ToLower();
            PopulateIndividualList(website.textHTML, findFrom, findTo, highestWinItemList);

            findFrom = ("<h2 class=\"champion-stats\">Most Frequent Starters</h2>").ToLower();
            findTo = ("<h2 class=\"champion-stats\" style=\"margin-top:40px\">Highest Win % Starters</h2>").ToLower();
            PopulateIndividualList(website.textHTML, findFrom, findTo, popularStarterList);

            findFrom = ("<h2 class=\"champion-stats\" style=\"margin-top:40px\">Highest Win % Starters</h2>").ToLower();
            findTo = ("<h2 class=\"champion-stats\">Most Frequent Masteries</h2>").ToLower();
            PopulateIndividualList(website.textHTML, findFrom, findTo, highestWinStarterList);

            findFrom = ("<small>Patch <strong>").ToLower();
            findTo = ("</strong> <span class=\"spacer\">|</span> Games Analyzed").ToLower();
            string[] splitValues = Helper.StringBetween(website.textHTML, findFrom, findTo).Split('\n');
            patch = splitValues[0] ?? "";
        }
        #endregion
    }
}
