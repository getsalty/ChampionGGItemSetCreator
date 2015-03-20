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
    class ChampionList
    {
        public List<Champion> champions = new List<Champion>();

        /// <summary>
        /// Loads all the champion info. 
        /// </summary>
        public void LoadChampions()
        {
            champions.Add(new Champion("Aatrox", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Ahri", new string[] { Helper.Middle }));
            champions.Add(new Champion("Akali", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Alistar", new string[] { Helper.Support }));
            champions.Add(new Champion("Amumu", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Anivia", new string[] { Helper.Middle }));
            champions.Add(new Champion("Annie", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Ashe", new string[] { Helper.ADC }));
            champions.Add(new Champion("Azir", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Blitzcrank", new string[] { Helper.Support }));
            champions.Add(new Champion("Brand", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Braum", new string[] { Helper.Support }));
            champions.Add(new Champion("Caitlyn", new string[] { Helper.ADC }));
            champions.Add(new Champion("Cassiopeia", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Chogath", new string[] { Helper.Top, Helper.Middle, Helper.Jungle }));
            champions.Add(new Champion("Corki", new string[] { Helper.ADC }));
            champions.Add(new Champion("Darius", new string[] { Helper.Top }));
            champions.Add(new Champion("Diana", new string[] { Helper.Top, Helper.Jungle, Helper.Middle }));
            champions.Add(new Champion("Draven", new string[] { Helper.ADC }));
            champions.Add(new Champion("DrMundo", new string[] { Helper.Top }));
            champions.Add(new Champion("Elise", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Evelynn", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Ezreal", new string[] { Helper.ADC, Helper.Middle }));
            champions.Add(new Champion("FiddleSticks", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Fiora", new string[] { Helper.Top }));
            champions.Add(new Champion("Fizz", new string[] { Helper.Top, Helper.Jungle, Helper.Middle }));
            champions.Add(new Champion("Galio", new string[] { Helper.Top, Helper.Middle, Helper.Support }));
            champions.Add(new Champion("Gangplank", new string[] { Helper.Top }));
            champions.Add(new Champion("Garen", new string[] { Helper.Top }));
            champions.Add(new Champion("Gnar", new string[] { Helper.Top }));
            champions.Add(new Champion("Gragas", new string[] { Helper.Top, Helper.Jungle, Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Graves", new string[] { Helper.ADC }));
            champions.Add(new Champion("Hecarim", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Heimerdinger", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Irelia", new string[] { Helper.Top }));
            champions.Add(new Champion("Janna", new string[] { Helper.Support }));
            champions.Add(new Champion("JarvanIV", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Jax", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Jayce", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Jinx", new string[] { Helper.ADC }));
            champions.Add(new Champion("Kalista", new string[] { Helper.ADC }));
            champions.Add(new Champion("Karma", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Karthus", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Kassadin", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Katarina", new string[] { Helper.Middle }));
            champions.Add(new Champion("Kayle", new string[] { Helper.Top, Helper.Jungle, Helper.Middle }));
            champions.Add(new Champion("Kennen", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Khazix", new string[] { Helper.Jungle }));
            champions.Add(new Champion("KogMaw", new string[] { Helper.ADC, Helper.Middle }));
            champions.Add(new Champion("Leblanc", new string[] { Helper.Middle }));
            champions.Add(new Champion("LeeSin", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Leona", new string[] { Helper.Support }));
            champions.Add(new Champion("Lissandra", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Lucian", new string[] { Helper.ADC }));
            champions.Add(new Champion("Lulu", new string[] { Helper.Top, Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Lux", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Malphite", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Malzahar", new string[] { Helper.Middle }));
            champions.Add(new Champion("Maokai", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("MasterYi", new string[] { Helper.Jungle }));
            champions.Add(new Champion("MissFortune", new string[] { Helper.ADC }));
            champions.Add(new Champion("MonkeyKing", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Mordekaiser", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Morgana", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Nami", new string[] { Helper.Support }));
            champions.Add(new Champion("Nasus", new string[] { Helper.Top }));
            champions.Add(new Champion("Nautilus", new string[] { Helper.Jungle, Helper.Support }));
            champions.Add(new Champion("Nidalee", new string[] { Helper.Top, Helper.Middle, Helper.Jungle }));
            champions.Add(new Champion("Nocturne", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Nunu", new string[] { Helper.Support, Helper.Jungle }));
            champions.Add(new Champion("Olaf", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Orianna", new string[] { Helper.Middle }));
            champions.Add(new Champion("Pantheon", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Poppy", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Quinn", new string[] { Helper.ADC, Helper.Top }));
            champions.Add(new Champion("Rammus", new string[] { Helper.Jungle }));
            champions.Add(new Champion("RekSai", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Renekton", new string[] { Helper.Top }));
            champions.Add(new Champion("Rengar", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Riven", new string[] { Helper.Top }));
            champions.Add(new Champion("Rumble", new string[] { Helper.Top }));
            champions.Add(new Champion("Ryze", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Sejuani", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Shaco", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Shen", new string[] { Helper.Top }));
            champions.Add(new Champion("Shyvana", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Singed", new string[] { Helper.Top }));
            champions.Add(new Champion("Sion", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Sivir", new string[] { Helper.ADC }));
            champions.Add(new Champion("Skarner", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Sona", new string[] { Helper.Support }));
            champions.Add(new Champion("Soraka", new string[] { Helper.Support }));
            champions.Add(new Champion("Swain", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Syndra", new string[] { Helper.Middle }));
            champions.Add(new Champion("Talon", new string[] { Helper.Middle }));
            champions.Add(new Champion("Taric", new string[] { Helper.Support }));
            champions.Add(new Champion("Teemo", new string[] { Helper.Top }));
            champions.Add(new Champion("Thresh", new string[] { Helper.Support }));
            champions.Add(new Champion("Tristana", new string[] { Helper.ADC }));
            champions.Add(new Champion("Trundle", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Tryndamere", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("TwistedFate", new string[] { Helper.Middle }));
            champions.Add(new Champion("Twitch", new string[] { Helper.ADC }));
            champions.Add(new Champion("Udyr", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Urgot", new string[] { Helper.Top }));
            champions.Add(new Champion("Varus", new string[] { Helper.ADC }));
            champions.Add(new Champion("Vayne", new string[] { Helper.ADC }));
            champions.Add(new Champion("Veigar", new string[] { Helper.Middle })); // support
            champions.Add(new Champion("Velkoz", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Vi", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Viktor", new string[] { Helper.Middle }));
            champions.Add(new Champion("Vladimir", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Volibear", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Warwick", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Xerath", new string[] { Helper.Middle }));
            champions.Add(new Champion("XinZhao", new string[] { Helper.Jungle }));
            champions.Add(new Champion("Yasuo", new string[] { Helper.Top, Helper.Middle }));
            champions.Add(new Champion("Yorick", new string[] { Helper.Top }));
            champions.Add(new Champion("Zac", new string[] { Helper.Top, Helper.Jungle }));
            champions.Add(new Champion("Zed", new string[] { Helper.Middle }));
            champions.Add(new Champion("Ziggs", new string[] { Helper.Middle }));
            champions.Add(new Champion("Zilean", new string[] { Helper.Support, Helper.Middle }));
            champions.Add(new Champion("Zyra", new string[] { Helper.Support, Helper.Middle }));
        }
    }
}
