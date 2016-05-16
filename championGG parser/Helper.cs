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
    static class Helper
    {
        public const string Top = "Top";
        public const string Jungle = "Jungle";
        public const string Middle = "Middle";
        public const string ADC = "ADC";
        public const string Support = "Support";
        public static Dictionary<short, string> gameItems = new Dictionary<short, string>();

        /// <summary>
        /// Gets the string from the source that is inbetween the "from" and "to" locations.
        /// </summary>
        /// <param name="source">The source that will be parsed.</param>
        /// <param name="from">The starting string for the parsing.</param>
        /// <param name="to">The ending string for the parsing.</param>
        /// <param name="remove">Do you want to remove the substring.</param>
        /// <returns>The substring between "from" and "to".</returns>
        public static string StringBetween(ref string source, string from, string to, bool remove)
        {
            int start = source.IndexOf(from);
            int finish = start > -1 ? source.IndexOf(to, start + from.Length) : -1;

            string returnString = "";

            if (start < 0 || finish < 0)
            {
                return returnString;
            }
            else
            {
                returnString = source.Substring(start + from.Length, finish - start - from.Length);
                if (remove)
                {
                    int i = source.Length;
                    source = source.Remove(start, finish - start);
                    i = source.Length;
                }
                return returnString;
            }
        }

        /// <summary>
        /// Populates the dictoionary for all in-game items.
        /// </summary>
        public static void LoadItems()
        {
            gameItems.Add(1001, "Boots of Speed");
            gameItems.Add(1004, "Faerie Charm");
            gameItems.Add(1006, "Rejuvenation Bead");
            gameItems.Add(1011, "Giant's Belt");
            gameItems.Add(1018, "Cloak of Agility");
            gameItems.Add(1026, "Blasting Wand");
            gameItems.Add(1027, "Sapphire Crystal");
            gameItems.Add(1028, "Ruby Crystal");
            gameItems.Add(1029, "Cloth Armor");
            gameItems.Add(1031, "Chain Vest");
            gameItems.Add(1033, "Null-Magic Mantle");
            gameItems.Add(1036, "Long Sword");
            gameItems.Add(1037, "Pickaxe");
            gameItems.Add(1038, "B. F. Sword");
            gameItems.Add(1039, "Hunter's Talisman");
            gameItems.Add(1041, "Hunter's Machete");
            gameItems.Add(1042, "Dagger");
            gameItems.Add(1043, "Recurve Bow");
            gameItems.Add(1051, "Brawler's Gloves");
            gameItems.Add(1052, "Amplifying Tome");
            gameItems.Add(1053, "Vampiric Scepter");
            gameItems.Add(1054, "Doran's Shield");
            gameItems.Add(1055, "Doran's Blade");
            gameItems.Add(1056, "Doran's Ring");
            gameItems.Add(1057, "Negatron Cloak");
            gameItems.Add(1058, "Needlessly Large Rod");
            gameItems.Add(1062, "Prospector's Blade");
            gameItems.Add(1063, "Prospector's Ring");
            gameItems.Add(1074, "Doran's Shield (Showdown)");
            gameItems.Add(1075, "Doran's Blade (Showdown)");
            gameItems.Add(1076, "Doran's Ring (Showdown)");
            gameItems.Add(1082, "The Dark Seal");
            gameItems.Add(1083, "Cull");
            gameItems.Add(1400, "Enchantment: Warrior");
            gameItems.Add(1401, "Enchantment: Cinderhulk");
            gameItems.Add(1402, "Enchantment: Runeglaive");
            gameItems.Add(1403, "Enchantment: Devourer");
            gameItems.Add(1408, "Enchantment: Warrior");
            gameItems.Add(1409, "Enchantment: Cinderhulk");
            gameItems.Add(1410, "Enchantment: Runeglaive");
            gameItems.Add(1411, "Enchantment: Devourer");
            gameItems.Add(1412, "Enchantment: Warrior");
            gameItems.Add(1413, "Enchantment: Cinderhulk");
            gameItems.Add(1414, "Enchantment: Runeglaive");
            gameItems.Add(1415, "Enchantment: Devourer");
            gameItems.Add(1416, "Enchantment: Bloodrazor");
            gameItems.Add(1419, "Enchantment: Bloodrazor");
            gameItems.Add(2003, "Health Potion");
            gameItems.Add(2004, "Mana Potion");
            gameItems.Add(2031, "Refillable Potion");
            gameItems.Add(2032, "Hunter's Potion");
            gameItems.Add(2033, "Corrupting Potion");
            gameItems.Add(2041, "Crystalline Flask");
            gameItems.Add(2043, "Vision Ward");
            gameItems.Add(2044, "Stealth Ward");
            gameItems.Add(2045, "Ruby Sightstone");
            gameItems.Add(2047, "Oracle's Extract");
            gameItems.Add(2049, "Sightstone");
            gameItems.Add(2051, "Guardian's Horn");
            gameItems.Add(2053, "Raptor Cloak");
            gameItems.Add(2137, "Elixir of Ruin");
            gameItems.Add(2138, "Elixir of Iron");
            gameItems.Add(2139, "Elixir of Sorcery");
            gameItems.Add(2140, "Elixir of Wrath");
            gameItems.Add(3001, "Abyssal Scepter");
            gameItems.Add(3003, "Archangel's Staff");
            gameItems.Add(3004, "Manamune");
            gameItems.Add(3006, "Berserker's Greaves");
            gameItems.Add(3007, "Archangel's Staff (Crystal Scar)");
            gameItems.Add(3008, "Manamune (Crystal Scar)");
            gameItems.Add(3009, "Boots of Swiftness");
            gameItems.Add(3010, "Catalyst the Protector");
            gameItems.Add(3020, "Sorcerer's Shoes");
            gameItems.Add(3022, "Frozen Mallet");
            gameItems.Add(3023, "Twin Shadows");
            gameItems.Add(3024, "Glacial Shroud");
            gameItems.Add(3025, "Iceborn Gauntlet");
            gameItems.Add(3026, "Guardian Angel");
            gameItems.Add(3027, "Rod of Ages");
            gameItems.Add(3028, "Chalice of Harmony");
            gameItems.Add(3029, "Rod of Ages (Crystal Scar)");
            gameItems.Add(3030, "Hextech GLP-800");
            gameItems.Add(3031, "Infinity Edge");
            gameItems.Add(3033, "Mortal Reminder");
            gameItems.Add(3035, "Last Whisper");
            gameItems.Add(3036, "Lord Dominik's Regards");
            gameItems.Add(3041, "Mejai's Soulstealer");
            gameItems.Add(3044, "Phage");
            gameItems.Add(3046, "Phantom Dancer");
            gameItems.Add(3047, "Ninja Tabi");
            gameItems.Add(3050, "Zeke's Herald");
            gameItems.Add(3053, "Sterak's Gage");
            gameItems.Add(3056, "Ohmwrecker");
            gameItems.Add(3057, "Sheen");
            gameItems.Add(3060, "Banner of Command");
            gameItems.Add(3065, "Spirit Visage");
            gameItems.Add(3067, "Kindlegem");
            gameItems.Add(3068, "Sunfire Cape");
            gameItems.Add(3069, "Talisman of Ascension");
            gameItems.Add(3070, "Tear of the Goddess");
            gameItems.Add(3071, "The Black Cleaver");
            gameItems.Add(3072, "The Bloodthirster");
            gameItems.Add(3073, "Tear of the Goddess (Crystal Scar)");
            gameItems.Add(3074, "Ravenous Hydra (Melee Only)");
            gameItems.Add(3075, "Thornmail");
            gameItems.Add(3077, "Tiamat (Melee Only)");
            gameItems.Add(3078, "Trinity Force");
            gameItems.Add(3082, "Warden's Mail");
            gameItems.Add(3083, "Warmog's Armor");
            gameItems.Add(3084, "Overlord's Bloodmail");
            gameItems.Add(3085, "Runaan's Hurricane (Ranged Only)");
            gameItems.Add(3086, "Zeal");
            gameItems.Add(3087, "Statikk Shiv");
            gameItems.Add(3089, "Rabadon's Deathcap");
            gameItems.Add(3090, "Wooglet's Witchcap");
            gameItems.Add(3091, "Wit's End");
            gameItems.Add(3092, "Frost Queen's Claim");
            gameItems.Add(3093, "Avarice Blade");
            gameItems.Add(3094, "Rapid Firecannon");
            gameItems.Add(3096, "Nomad's Medallion");
            gameItems.Add(3097, "Targon's Brace");
            gameItems.Add(3098, "Frostfang");
            gameItems.Add(3100, "Lich Bane");
            gameItems.Add(3101, "Stinger");
            gameItems.Add(3102, "Banshee's Veil");
            gameItems.Add(3104, "Lord Van Damm's Pillager");
            gameItems.Add(3105, "Aegis of the Legion");
            gameItems.Add(3106, "Madred's Razors");
            gameItems.Add(3108, "Fiendish Codex");
            gameItems.Add(3110, "Frozen Heart");
            gameItems.Add(3111, "Mercury's Treads");
            gameItems.Add(3112, "Orb of Winter");
            gameItems.Add(3113, "Aether Wisp");
            gameItems.Add(3114, "Forbidden Idol");
            gameItems.Add(3115, "Nashor's Tooth");
            gameItems.Add(3116, "Rylai's Crystal Scepter");
            gameItems.Add(3117, "Boots of Mobility");
            gameItems.Add(3122, "Wicked Hatchet");
            gameItems.Add(3124, "Guinsoo's Rageblade");
            gameItems.Add(3134, "The Brutalizer");
            gameItems.Add(3135, "Void Staff");
            gameItems.Add(3136, "Haunting Guise");
            gameItems.Add(3137, "Dervish Blade");
            gameItems.Add(3139, "Mercurial Scimitar");
            gameItems.Add(3140, "Quicksilver Sash");
            gameItems.Add(3141, "Sword of the Occult");
            gameItems.Add(3142, "Youmuu's Ghostblade");
            gameItems.Add(3143, "Randuin's Omen");
            gameItems.Add(3144, "Bilgewater Cutlass");
            gameItems.Add(3145, "Hextech Revolver");
            gameItems.Add(3146, "Hextech Gunblade");
            gameItems.Add(3147, "Duskblade of Draktharr");
            gameItems.Add(3151, "Liandry's Torment");
            gameItems.Add(3152, "Will of the Ancients");
            gameItems.Add(3153, "Blade of the Ruined King");
            gameItems.Add(3154, "Wriggle's Lantern");
            gameItems.Add(3155, "Hexdrinker");
            gameItems.Add(3156, "Maw of Malmortius");
            gameItems.Add(3157, "Zhonya's Hourglass");
            gameItems.Add(3158, "Ionian Boots of Lucidity");
            gameItems.Add(3159, "Grez's Spectral Lantern");
            gameItems.Add(3165, "Morellonomicon");
            gameItems.Add(3166, "Bonetooth Necklace");
            gameItems.Add(3170, "Moonflair Spellblade");
            gameItems.Add(3172, "Zephyr");
            gameItems.Add(3174, "Athene's Unholy Grail");
            gameItems.Add(3180, "Odyn's Veil");
            gameItems.Add(3181, "Sanguine Blade");
            gameItems.Add(3184, "Entropy");
            gameItems.Add(3185, "The Lightbringer");
            gameItems.Add(3187, "Hextech Sweeper");
            gameItems.Add(3190, "Locket of the Iron Solari");
            gameItems.Add(3191, "Seeker's Armguard");
            gameItems.Add(3196, "The Hex Core mk-1");
            gameItems.Add(3197, "The Hex Core mk-2");
            gameItems.Add(3198, "Perfect Hex Core");
            gameItems.Add(3211, "Spectre's Cowl");
            gameItems.Add(3222, "Mikael's Crucible");
            gameItems.Add(3250, "Enchantment: Homeguard");
            gameItems.Add(3251, "Enchantment: Captain");
            gameItems.Add(3252, "Enchantment: Furor");
            gameItems.Add(3253, "Enchantment: Distortion");
            gameItems.Add(3254, "Enchantment: Alacrity");
            gameItems.Add(3255, "Enchantment: Homeguard");
            gameItems.Add(3256, "Enchantment: Captain");
            gameItems.Add(3257, "Enchantment: Furor");
            gameItems.Add(3258, "Enchantment: Distortion");
            gameItems.Add(3259, "Enchantment: Alacrity");
            gameItems.Add(3260, "Enchantment: Homeguard");
            gameItems.Add(3261, "Enchantment: Captain");
            gameItems.Add(3262, "Enchantment: Furor");
            gameItems.Add(3263, "Enchantment: Distortion");
            gameItems.Add(3264, "Enchantment: Alacrity");
            gameItems.Add(3265, "Enchantment: Homeguard");
            gameItems.Add(3266, "Enchantment: Captain");
            gameItems.Add(3267, "Enchantment: Furor");
            gameItems.Add(3268, "Enchantment: Distortion");
            gameItems.Add(3269, "Enchantment: Alacrity");
            gameItems.Add(3270, "Enchantment: Homeguard");
            gameItems.Add(3271, "Enchantment: Captain");
            gameItems.Add(3272, "Enchantment: Furor");
            gameItems.Add(3273, "Enchantment: Distortion");
            gameItems.Add(3274, "Enchantment: Alacrity");
            gameItems.Add(3275, "Enchantment: Homeguard");
            gameItems.Add(3276, "Enchantment: Captain");
            gameItems.Add(3277, "Enchantment: Furor");
            gameItems.Add(3278, "Enchantment: Distortion");
            gameItems.Add(3279, "Enchantment: Alacrity");
            gameItems.Add(3280, "Enchantment: Homeguard");
            gameItems.Add(3281, "Enchantment: Captain");
            gameItems.Add(3282, "Enchantment: Furor");
            gameItems.Add(3283, "Enchantment: Distortion");
            gameItems.Add(3284, "Enchantment: Alacrity");
            gameItems.Add(3285, "Luden's Echo");
            gameItems.Add(3290, "Twin Shadows");
            gameItems.Add(3301, "Ancient Coin");
            gameItems.Add(3302, "Relic Shield");
            gameItems.Add(3303, "Spellthief's Edge");
            gameItems.Add(3340, "Warding Totem (Trinket)");
            gameItems.Add(3341, "Sweeping Lens (Trinket)");
            gameItems.Add(3342, "Scrying Orb (Trinket)");
            gameItems.Add(3345, "Soul Anchor (Trinket)");
            gameItems.Add(3361, "Greater Stealth Totem (Trinket)");
            gameItems.Add(3362, "Greater Vision Totem (Trinket)");
            gameItems.Add(3363, "Farsight Orb (Trinket)");
            gameItems.Add(3364, "Oracle's Lens (Trinket)");
            gameItems.Add(3401, "Face of the Mountain");
            gameItems.Add(3405, "Bonetooth Necklace");
            gameItems.Add(3411, "Bonetooth Necklace");
            gameItems.Add(3417, "Bonetooth Necklace");
            gameItems.Add(3450, "Bonetooth Necklace");
            gameItems.Add(3504, "Ardent Censer");
            gameItems.Add(3508, "Essence Reaver");
            gameItems.Add(3512, "Zz'Rot Portal");
            gameItems.Add(3599, "The Black Spear");
            gameItems.Add(3706, "Stalker's Blade");
            gameItems.Add(3707, "Enchantment: Warrior");
            gameItems.Add(3708, "Enchantment: Magus");
            gameItems.Add(3709, "Enchantment: Cinderhulk");
            gameItems.Add(3710, "Enchantment: Devourer");
            gameItems.Add(3711, "Poacher's Knife");
            gameItems.Add(3713, "Ranger's Trailblazer");
            gameItems.Add(3714, "Enchantment: Warrior");
            gameItems.Add(3715, "Skirmisher's Sabre");
            gameItems.Add(3716, "Enchantment: Magus");
            gameItems.Add(3717, "Enchantment: Cinderhulk");
            gameItems.Add(3718, "Enchantment: Devourer");
            gameItems.Add(3719, "Enchantment: Warrior");
            gameItems.Add(3720, "Enchantment: Magus");
            gameItems.Add(3721, "Enchantment: Cinderhulk");
            gameItems.Add(3722, "Enchantment: Devourer");
            gameItems.Add(3723, "Enchantment: Warrior");
            gameItems.Add(3724, "Enchantment: Magus");
            gameItems.Add(3725, "Enchantment: Cinderhulk");
            gameItems.Add(3726, "Enchantment: Devourer");
            gameItems.Add(3742, "Dead Man's Plate");
            gameItems.Add(3748, "Titanic Hydra (Melee Only)");
            gameItems.Add(3751, "Bami's Cinder");
            gameItems.Add(3800, "Righteous Glory");
            gameItems.Add(3801, "Crystalline Bracer");
            gameItems.Add(3812, "Death's Dance");
            gameItems.Add(3902, "Death's Daughter");
        }

    }
}
