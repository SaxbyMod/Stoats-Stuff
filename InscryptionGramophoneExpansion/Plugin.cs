using HarmonyLib;
using BepInEx;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI;
using InscryptionAPI.Saves;
using InscryptionAPI.Card;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using InscryptionAPI.Boons;
using InscryptionAPI.Nodes;
using InscryptionCommunityPatch.Card;
using InscryptionAPI.Triggers;
using GramophoneAPI.Sound;
using BepInEx.Configuration;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("kel.inscryption.gramophoneAPI", BepInDependency.DependencyFlags.SoftDependency)]

    
    public class Plugin : BaseUnityPlugin
    {
        Harmony harmony = new Harmony(PluginGuid);

        private const string PluginGuid = "creator.inscryption.gramophone.add.tracks";
        private const string PluginName = "InscryptionGramaphoneMod";
        private const string PluginVersion = "2.4.0";

        public ConfigEntry<bool> configEnableInscryptionPack;
        public ConfigEntry<bool> configEnableHexPack;
        public ConfigEntry<bool> configEnablePonyIslandPack;

        public void Awake()
        {
            configEnableInscryptionPack = Config.Bind<bool>("General.Toggles",
                                                "Inscryption Pack?",
                                                true,
                                                "Should Inscryption Pack be Enabled? [Incompatible with Hex Pack]");
            configEnableHexPack = Config.Bind<bool>("General.Toggles",
                                    "Hex Pack?",
                                    false,
                                    "Should Hex Pack be Enabled? [Incompatible with Inscryption Pack]");
            configEnablePonyIslandPack = Config.Bind<bool>("General.Toggles",
                                    "Pony Island Pack?",
                                    false,
                                    "Should Pony Island Pack be Enabled?");

                int MusicAmount = 0;

                // Apply our harmony patches.
                harmony.PatchAll(typeof(Plugin));
            if (configEnableInscryptionPack.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "01.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "03.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "04.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "05.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "06.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "07.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "08.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "09.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "10.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "11.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "12.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "13.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "14.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "15.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "16.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "17.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "18.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "19.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "20.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "23.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "24.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "25.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "26.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "27.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "28.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "29.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "30.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "31.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "32.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "34.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "35.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "36.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "37.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "38.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "39.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "41.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "42.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "43.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "44.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "45.mp3");

                MusicAmount++;
            }
            else
            {

                Logger.LogInfo($"The Inscryption Pack Is Disabled");
            }
            if (configEnableHexPack.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Hex_01.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_02.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_03.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_04.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_05.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_06.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_08.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_09.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_10.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_11.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_12.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_13.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_14.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_15.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_16.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_17.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_18.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_19.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_20.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_21.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_22.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_23.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_24.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_25.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_26.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_27.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_29.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_31.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Hex_32.mp3");

                MusicAmount++;
            } else
            {
                Logger.LogInfo($"The Hex Pack Is Disabled");
            }
            if (configEnablePonyIslandPack.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "Pony_01.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_02.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_03.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_04.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_05.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_06.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_07.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_08.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_09.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_10.mp3");

                MusicAmount++;

                GramophoneManager.AddTrack(PluginGuid, "Pony_11.mp3");

                MusicAmount++;
            } else
            {
                Logger.LogInfo($"The Pony Island Pack Is Disabled");
            }
                Logger.LogInfo($"Sucsessfully Loaded {MusicAmount} Song(s)");

            
        }
    }
}
