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
using InscryptionAPI.Sound;
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
        private const string PluginVersion = "1.0.0";

        //Initializes the configs
        public ConfigEntry<bool> configEnableTitleTheme;
        public ConfigEntry<bool> configEnableSFXTheAngler;
        public ConfigEntry<bool> configEnableTheAngler;
        public ConfigEntry<bool> configEnableSFXTheProspector;
        public ConfigEntry<bool> configEnableTheProspector;
        public ConfigEntry<bool> configEnableSFXTheTrapper;
        public ConfigEntry<bool> configEnableTheTrapper;
        public ConfigEntry<bool> configEnableAWalkInTheWoods;
        public ConfigEntry<bool> configEnableLeshysTheme;
        public ConfigEntry<bool> configEnableLeshysThemeAngler;
        public ConfigEntry<bool> configEnableLeshysThemeAnglerSFX;
        public ConfigEntry<bool> configEnableLeshysThemeProspector;
        public ConfigEntry<bool> configEnableLeshysThemeProspectorSFX;
        public ConfigEntry<bool> configEnableLeshysThemeTrapper;
        public ConfigEntry<bool> configEnableLeshysThemeTrapperSFX;
        public ConfigEntry<bool> configEnableTheMoon;
        public ConfigEntry<bool> configEnableLongForgottenMonuments;
        public ConfigEntry<bool> configEnableTheFourScrybes;
        public ConfigEntry<bool> configEnableTempleOfTheDead;
        public ConfigEntry<bool> configEnableTempleOfTechnology;
        public ConfigEntry<bool> configEnableCardplay;
        public ConfigEntry<bool> configEnableCardplayUndead;
        public ConfigEntry<bool> configEnableCardPlayBeast;
        public ConfigEntry<bool> configEnableCardPlayMagiks;
        public ConfigEntry<bool> configEnableCardplayTechnology;
        public ConfigEntry<bool> configEnableScrybeofTheUndead;
        public ConfigEntry<bool> configEnableScrybeofTheBeasts;
        public ConfigEntry<bool> configEnableScrybeofTheMagiks;
        public ConfigEntry<bool> configEnableScrybeofTheTechnology;
        public ConfigEntry<bool> configEnableDamageRace;
        public ConfigEntry<bool> configEnableBountyHunters;
        public ConfigEntry<bool> configEnableUberBotActivated;
        public ConfigEntry<bool> configEnableUberBotActivatedBlankCanvas;
        public ConfigEntry<bool> configEnableUberBotActivatedGollysTheme;
        public ConfigEntry<bool> configEnableUberBotActivatedGollysThemeUploading;
        public ConfigEntry<bool> configEnableFinalDuel;
        public ConfigEntry<bool> configEnableDeathcardCabinReprise;
        public ConfigEntry<bool> configEnableAnglerMashup;
        public ConfigEntry<bool> configEnableProspectorMashup;
        public ConfigEntry<bool> configEnableTrapperMashup;
        public ConfigEntry<bool> configEnableUberBotActivatedArchivest;
        public ConfigEntry<bool> configEnableRoyalsTheme;

        public void Awake()
        {
            // Summpms The Config file
            configEnableTitleTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Title Theme?",
                                    true,
                                    "Should the 'Title Theme' Show up on the Gramophone?");
            configEnableSFXTheAngler = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Angler + SFX",
                                    false,
                                    "Should the 'The Angler + SFX' Show up on the Gramophone?");
            configEnableTheAngler = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Angler?",
                                    true,
                                    "Should the 'The Angler' Show up on the Gramophone?");
            configEnableSFXTheProspector = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Prospector + SFX?",
                                    false,
                                    "Should the 'The Prospector + SFX' Show up on the Gramophone?");
            configEnableTheProspector = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Prospector?",
                                    true,
                                    "Should the 'The Prospector' Show up on the Gramophone?");
            configEnableSFXTheTrapper = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Trapper + SFX?",
                                    false,
                                    "Should the 'The Trapper + SFX' Show up on the Gramophone?");
            configEnableTheTrapper = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Trapper?",
                                    true,
                                    "Should the 'The Trapper' Show up on the Gramophone?");
            configEnableAWalkInTheWoods = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "A Walk In The Woods?",
                                    true,
                                    "Should the 'A Walk In The Woods' Show up on the Gramophone?");
            configEnableLeshysTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme?",
                                    true,
                                    "Should the 'Leshys Theme' Show up on the Gramophone?");
            configEnableLeshysThemeAngler = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme + Angler?",
                                    true,
                                    "Should the 'Leshys Theme + Angler' Show up on the Gramophone?");
            configEnableLeshysThemeAnglerSFX = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme + Angler + SFX?",
                                    false,
                                    "Should the 'Leshys Theme + Angler + SFX' Show up on the Gramophone?");
            configEnableLeshysThemeProspector = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme + Prospector?",
                                    true,
                                    "Should the 'Leshys Theme + Prospector' Show up on the Gramophone?");
            configEnableLeshysThemeProspectorSFX = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme + Prospector + SFX?",
                                    false,
                                    "Should the 'Leshys Theme + Prospector + SFX' Show up on the Gramophone?");
            configEnableLeshysThemeTrapper = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme + Trapper?",
                                    true,
                                    "Should the 'Leshys Theme + Trapper' Show up on the Gramophone?");
            configEnableLeshysThemeTrapperSFX = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Leshys Theme + Trapper + SFX?",
                                    false,
                                    "Should the 'Leshys Theme + Trapper + SFX' Show up on the Gramophone?");
            configEnableTheMoon = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Moon?",
                                    true,
                                    "Should the 'The Moon' Show up on the Gramophone?");
            configEnableLongForgottenMonuments = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Long Forgotten Monuments?",
                                    true,
                                    "Should the 'Long Forgotten Monuments' Show up on the Gramophone?");
            configEnableTheFourScrybes = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Four Scrybes?",
                                    true,
                                    "Should the 'The Four Scrybes' Show up on the Gramophone?");
            configEnableTempleOfTheDead = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Temple of the Dead?",
                                    true,
                                    "Should the 'The Temple of The dead' Show up on the Gramophone?");
            configEnableTempleOfTechnology = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "The Temple of Technology?",
                                    true,
                                    "Should the 'The Temple of Technology' Show up on the Gramophone?");
            configEnableCardplay = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Cardplay?",
                                    true,
                                    "Should 'Cardplay' show up on the Gramophone");
            configEnableCardplayUndead = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Cardplay + Undead?",
                                     true,
                                     "Should 'Card Play + Undead' show up on the gramophone");
            configEnableCardPlayBeast = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Cardplay + Beast?",
                                    true,
                                    "Should 'Cardplay + Beast' show up on the gramophone?"
                                    );
            configEnableCardPlayMagiks = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Cardplay + Magiks?",
                                    true,
                                    "Should 'Cardplay + Magiks' show up on the gramophone?"
                                    );
            configEnableCardplayTechnology = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Cardplay + Technology?",
                                    true,
                                    "Should 'Cardplay + Technology' show up on the gramophone?"
                                    );
            configEnableScrybeofTheUndead = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Scrybe of the Undead?",
                                    true,
                                    "Should 'Scrybe of the Undead' show up on the gramophone?"
                                    );
            configEnableScrybeofTheBeasts = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Scrybe of the Beasts?",
                                    true,
                                    "Should 'Scrybe of the Beasts' show up on the gramophone?"
                                    );
            configEnableScrybeofTheMagiks = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Scrybe of the Magiks?",
                                    true,
                                    "Should 'Scrybe of the Magiks' show up on the gramophone?"
                                    );
            configEnableScrybeofTheTechnology = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Scrybe of the Technology?",
                                    true,
                                    "Should 'Scrybe of the Technology' show up on the gramophone?"
                                    );
            configEnableDamageRace = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Damage Race?",
                                    true,
                                    "Should 'Damage Race' show up on the gramophone?"
                                    );
            configEnableBountyHunters = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Bounty Hunters?",
                                    true,
                                    "Should 'Bounty Hunters' show up on the gramophone?"
                                    );
            configEnableUberBotActivated = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Uber Bot Activated?",
                                    true,
                                    "Should 'Uber Bot Activated' show up on the gramophone?"
                                    );
            configEnableUberBotActivatedBlankCanvas = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Uber Bot Activated + Blank Canvas?",
                                    true,
                                    "Should 'Uber Bot Activated + Blank Canvas' show up on the gramophone?"
                                    );
            configEnableUberBotActivatedGollysTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Uber Bot Activated + Gollys Theme?",
                                    true,
                                    "Should 'Uber Bot Activated + Gollys Theme' show up on the gramophone?"
                                    );
            configEnableUberBotActivatedGollysThemeUploading = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Uber Bot Activated + Gollys Theme + Uploading?",
                                    true,
                                    "Should 'Uber Bot Activated + Gollys Theme + Uploading' show up on the gramophone?"
                                    );
            configEnableFinalDuel = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Final Duel?",
                                    true,
                                    "Should 'Final Duel' show up on the gramophone?"
                                    );
            configEnableDeathcardCabinReprise = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Deathcard Cabin + Reprise?",
                                    true,
                                    "Should 'Deathcard Cabin + Reprise' show up on the gramophone?"
                                    );
            configEnableAnglerMashup = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Angler Mashup?",
                                    true,
                                    "Should 'Angler Mashup' show up on the gramophone?"
                                    );
            configEnableProspectorMashup = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Prospector Mashup?",
                                    true,
                                    "Should 'Prospector Mashup' show up on the gramophone?"
                                    );
            configEnableTrapperMashup = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Trapper Mashup?",
                                    true,
                                    "Should 'Trapper Mashup' show up on the gramophone?"
                                    );
            configEnableUberBotActivatedArchivest = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Uber Bot Activated + Archivest?",
                                    true,
                                    "Should 'Uber Bot Activated + Archivest' show up on the gramophone?"
                                    );
            configEnableRoyalsTheme = Config.Bind<bool>("Gramopone.Enable.Songs",
                                    "Royals Theme?",
                                    true,
                                    "Should 'Royals Theme' show up on the gramophone?"
                                    );
            //Music Num
            int MusicAmount = 0;

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            //Summons the music
            if (configEnableTitleTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "01.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableSFXTheAngler.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "03.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheAngler.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "04.mp3", 0.5f);
                MusicAmount++;
            }
            if (configEnableSFXTheProspector.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "05.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheProspector.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "06.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableSFXTheTrapper.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "07.mp3", 0.5f);

                MusicAmount++;
            }
                if (configEnableTheTrapper.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "08.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableAWalkInTheWoods.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "09.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLeshysTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "10.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLeshysThemeAngler.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "11.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLeshysThemeAnglerSFX.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "03.mp3", 0.5f);

                MusicAmount++;
            }
                if (configEnableLeshysThemeProspector.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "13.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLeshysThemeProspectorSFX.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "03.mp3", 0.5f);

                MusicAmount++;
            }
                if (configEnableLeshysThemeTrapper.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "15.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLeshysThemeTrapperSFX.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "03.mp3", 0.5f);

                MusicAmount++;
            }
                if (configEnableTheMoon.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "17.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableLongForgottenMonuments.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "18.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTheFourScrybes.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "19.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTempleOfTheDead.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "20.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTempleOfTechnology.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "23.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableCardplay.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "24.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableCardplayUndead.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "25.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableCardPlayBeast.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "26.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableCardPlayMagiks.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "27.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableCardplayTechnology.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "28.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableScrybeofTheUndead.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "29.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableScrybeofTheBeasts.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "30.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableScrybeofTheMagiks.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "31.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableScrybeofTheTechnology.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "32.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableDamageRace.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "34.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableBountyHunters.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "35.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableUberBotActivated.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "36.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableUberBotActivatedBlankCanvas.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "37.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableUberBotActivatedGollysTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "38.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableUberBotActivatedGollysThemeUploading.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "39.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableFinalDuel.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "41.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableDeathcardCabinReprise.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "42.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableAnglerMashup.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "43.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableProspectorMashup.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "44.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableTrapperMashup.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "45.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableUberBotActivatedArchivest.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "46.mp3", 0.5f);

                MusicAmount++;
            }
            if (configEnableRoyalsTheme.Value)
            {
                GramophoneManager.AddTrack(PluginGuid, "47.mp3", 0.5f);
                MusicAmount++;
            }
            // Was this sucsessful?
            Logger.LogInfo($"Sucsessfully Loaded {MusicAmount} Song(s)");


        }
    }
}
