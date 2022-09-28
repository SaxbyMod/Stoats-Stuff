using BepInEx;
using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;

namespace TribalLibary
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
        
    {
        
        private const string PluginGuid = "tribes.libary";
        private const string PluginName = "TribeLibary";
        private const string PluginVersion = "1.0.0";

        public static Tribe skeletalTribe;
        public static Tribe fleshyTribe;
        public static Tribe spectralTribe;
        public static Tribe vesselTribe;
        public static Tribe conduitsTribe;
        public static Tribe cellsTribe;
        public static Tribe utillityTribe;
        public static Tribe securityTribe;
        public static Tribe scholarTribe;
        public static Tribe guardianTribe;
        public static Tribe moxTribe;
        public static Tribe tentacleTribe;
        public static Tribe everythingTribe;
        public static Tribe fungusTribe;



        public void Awake()
        {
            Logger.LogInfo($"Sucsessfully Loaded {PluginName}!");
            { 
             
                skeletalTribe = TribeManager.Add(
                    PluginGuid,
                    "skeletal",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_skeletal.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                fleshyTribe = TribeManager.Add(
                    PluginGuid,
                    "fleshy",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fleshy.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                spectralTribe = TribeManager.Add(
                    PluginGuid,
                    "spectral",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spectral.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                vesselTribe = TribeManager.Add(
                    PluginGuid,
                    "vessel",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_vessel.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                conduitsTribe = TribeManager.Add(
                    PluginGuid,
                    "conduits",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_conduits.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                cellsTribe = TribeManager.Add(
                    PluginGuid,
                    "cells",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cells.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                utillityTribe = TribeManager.Add(
                    PluginGuid,
                    "utillity",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_utillity.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                securityTribe = TribeManager.Add(
                    PluginGuid,
                    "security",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_security.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                scholarTribe = TribeManager.Add(
                    PluginGuid,
                    "scholar",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_scholar.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                guardianTribe = TribeManager.Add(
                    PluginGuid,
                    "guardian",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_guardian.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                moxTribe = TribeManager.Add(
                    PluginGuid,
                    "mox",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mox.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                tentacleTribe = TribeManager.Add(
                    PluginGuid,
                    "tentacle",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_tentacle.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                everythingTribe = TribeManager.Add(
                    PluginGuid,
                    "everything",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_everything.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
            {
                fungusTribe = TribeManager.Add(
                    PluginGuid,
                    "fungus",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fungus.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_example.png")
                 );
            }
        }
    }
}
