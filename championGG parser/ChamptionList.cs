//Copyright 2015 Garrett Long
//This file is part of ChampionGG Item Set Creator.
//ChampionGG Item Set Creator is free software: you can redistribute it and/or modify it under the terms of the GNU General 
//Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
//ChampionGG Item Set Creator is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//You should have received a copy of the GNU General Public License along with ChampionGG Item Set Creator. If not, see http://www.gnu.org/licenses/.

using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;

namespace championGG_parser
{
    public class ChampionList
    {
        public List<Champion> champions { get; set; }

        /// <summary>
        /// Main Constructor. Loads the champion list and then sends back enableItems bool.
        /// </summary>
        /// <param name="enableItems">Returns true if there is a json file with champion data already on computer.</param>
        public ChampionList(ref bool enableItems)
        {
            champions = new List<Champion>();

            dynamic test = "";
            if (File.Exists(@".\Resources\championData.json"))
            {
                test = JsonConvert.DeserializeObject(File.ReadAllText(@".\Resources\championData.json"));
            }
            if (LoadChampions(test))
            {
                enableItems = true;
            }
        }

        /// <summary>
        /// Loads all the champion info. 
        /// </summary>
        private bool LoadChampions(dynamic previousData)
        {
            champions.Add(new Champion("Aatrox"));
            champions.Add(new Champion("Ahri"));
            champions.Add(new Champion("Akali"));
            champions.Add(new Champion("Alistar"));
            champions.Add(new Champion("Amumu"));
            champions.Add(new Champion("Anivia"));
            champions.Add(new Champion("Annie"));
            champions.Add(new Champion("Ashe"));
            champions.Add(new Champion("Azir"));
            champions.Add(new Champion("Bard"));
            champions.Add(new Champion("Blitzcrank"));
            champions.Add(new Champion("Brand"));
            champions.Add(new Champion("Braum"));
            champions.Add(new Champion("Caitlyn"));
            champions.Add(new Champion("Cassiopeia"));
            champions.Add(new Champion("Chogath"));
            champions.Add(new Champion("Corki"));
            champions.Add(new Champion("Darius"));
            champions.Add(new Champion("Diana"));
            champions.Add(new Champion("Draven"));
            champions.Add(new Champion("DrMundo"));
            champions.Add(new Champion("Elise"));
            champions.Add(new Champion("Evelynn"));
            champions.Add(new Champion("Ezreal"));
            champions.Add(new Champion("FiddleSticks"));
            champions.Add(new Champion("Fiora"));
            champions.Add(new Champion("Fizz"));
            champions.Add(new Champion("Galio"));
            champions.Add(new Champion("Gangplank"));
            champions.Add(new Champion("Garen"));
            champions.Add(new Champion("Gnar"));
            champions.Add(new Champion("Gragas"));
            champions.Add(new Champion("Graves"));
            champions.Add(new Champion("Hecarim"));
            champions.Add(new Champion("Heimerdinger"));
            champions.Add(new Champion("Irelia"));
            champions.Add(new Champion("Janna"));
            champions.Add(new Champion("JarvanIV"));
            champions.Add(new Champion("Jax"));
            champions.Add(new Champion("Jayce"));
            champions.Add(new Champion("Jinx"));
            champions.Add(new Champion("Kalista"));
            champions.Add(new Champion("Karma"));
            champions.Add(new Champion("Karthus"));
            champions.Add(new Champion("Kassadin"));
            champions.Add(new Champion("Katarina"));
            champions.Add(new Champion("Kayle"));
            champions.Add(new Champion("Kennen"));
            champions.Add(new Champion("Khazix"));
            champions.Add(new Champion("KogMaw"));
            champions.Add(new Champion("Leblanc"));
            champions.Add(new Champion("LeeSin"));
            champions.Add(new Champion("Leona"));
            champions.Add(new Champion("Lissandra"));
            champions.Add(new Champion("Lucian"));
            champions.Add(new Champion("Lulu"));
            champions.Add(new Champion("Lux"));
            champions.Add(new Champion("Malphite"));
            champions.Add(new Champion("Malzahar"));
            champions.Add(new Champion("Maokai"));
            champions.Add(new Champion("MasterYi"));
            champions.Add(new Champion("MissFortune"));
            champions.Add(new Champion("MonkeyKing"));
            champions.Add(new Champion("Mordekaiser"));
            champions.Add(new Champion("Morgana"));
            champions.Add(new Champion("Nami"));
            champions.Add(new Champion("Nasus"));
            champions.Add(new Champion("Nautilus"));
            champions.Add(new Champion("Nidalee"));
            champions.Add(new Champion("Nocturne"));
            champions.Add(new Champion("Nunu"));
            champions.Add(new Champion("Olaf"));
            champions.Add(new Champion("Orianna"));
            champions.Add(new Champion("Pantheon"));
            champions.Add(new Champion("Poppy"));
            champions.Add(new Champion("Quinn"));
            champions.Add(new Champion("Rammus"));
            champions.Add(new Champion("RekSai"));
            champions.Add(new Champion("Renekton"));
            champions.Add(new Champion("Rengar"));
            champions.Add(new Champion("Riven"));
            champions.Add(new Champion("Rumble"));
            champions.Add(new Champion("Ryze"));
            champions.Add(new Champion("Sejuani"));
            champions.Add(new Champion("Shaco"));
            champions.Add(new Champion("Shen"));
            champions.Add(new Champion("Shyvana"));
            champions.Add(new Champion("Singed"));
            champions.Add(new Champion("Sion"));
            champions.Add(new Champion("Sivir"));
            champions.Add(new Champion("Skarner"));
            champions.Add(new Champion("Sona"));
            champions.Add(new Champion("Soraka"));
            champions.Add(new Champion("Swain"));
            champions.Add(new Champion("Syndra"));
            champions.Add(new Champion("Talon"));
            champions.Add(new Champion("Taric"));
            champions.Add(new Champion("Teemo"));
            champions.Add(new Champion("Thresh"));
            champions.Add(new Champion("Tristana"));
            champions.Add(new Champion("Trundle"));
            champions.Add(new Champion("Tryndamere"));
            champions.Add(new Champion("TwistedFate"));
            champions.Add(new Champion("Twitch"));
            champions.Add(new Champion("Udyr"));
            champions.Add(new Champion("Urgot"));
            champions.Add(new Champion("Varus"));
            champions.Add(new Champion("Vayne"));
            champions.Add(new Champion("Veigar"));
            champions.Add(new Champion("Velkoz"));
            champions.Add(new Champion("Vi"));
            champions.Add(new Champion("Viktor"));
            champions.Add(new Champion("Vladimir"));
            champions.Add(new Champion("Volibear"));
            champions.Add(new Champion("Warwick"));
            champions.Add(new Champion("Xerath"));
            champions.Add(new Champion("XinZhao"));
            champions.Add(new Champion("Yasuo"));
            champions.Add(new Champion("Yorick"));
            champions.Add(new Champion("Zac"));
            champions.Add(new Champion("Zed"));
            champions.Add(new Champion("Ziggs"));
            champions.Add(new Champion("Zilean"));
            champions.Add(new Champion("Zyra"));


            Website tmpWeb = new Website("http://champion.gg/");
            string tmpStr = tmpWeb.textHTML;
            string[] splitValues = Helper.StringBetween(ref tmpStr, "col-md-9", "col-md-3", true).Split('\n');

            foreach (var champion in champions)
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

            try
            {
                for (int i = 0; i < champions.Count; i++)
                {
                    for (int a = 0; a < previousData.champions[i].positions.Count; a++)
                    {
                        champions[i].positions[a].patch = previousData.champions[i].positions[a].patch;
                        champions[i].positions[a].skillOrder = previousData.champions[i].positions[a].skillOrder;
                        string name = previousData.champions[i].positions[a].name;
                        if (previousData.champions[i].positions[a].name == champions[i].positions[a].name)
                        {
                            foreach (var hwiList in previousData.champions[i].positions[a].highestWinItemList)
                            {
                                champions[i].positions[a].highestWinItemList.Add(new Item() { id = (short)hwiList.id, name = hwiList.name });
                            }

                            foreach (var popList in previousData.champions[i].positions[a].popularItemList)
                            {
                                champions[i].positions[a].popularItemList.Add(new Item() { id = (short)popList.id, name = popList.name });
                            }

                            foreach (var hwiSList in previousData.champions[i].positions[a].highestWinStarterList)
                            {
                                champions[i].positions[a].highestWinStarterList.Add(new Item() { id = (short)hwiSList.id, name = hwiSList.name });
                            }

                            foreach (var popSList in previousData.champions[i].positions[a].popularStarterList)
                            {
                                champions[i].positions[a].popularStarterList.Add(new Item() { id = (short)popSList.id, name = popSList.name });
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

    }
}
