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
        public static Tribe rodentTribe;
        public static Tribe ceromorphTribe;
        public static Tribe dragonTribe;
        public static Tribe fishTribe;
        public static Tribe beastTribe;
        public static Tribe beastwarriorTribe;
        public static Tribe aquaTribe;
        public static Tribe fairyTribe;
        public static Tribe plantTribe;
        public static Tribe pyroTribe;
        public static Tribe stoneTribe;
        public static Tribe thunderTribe;
        public static Tribe iceTribe;
        public static Tribe abominationTribe;
        public static Tribe cyberseTribe;
        public static Tribe dinosaurTribe;
        public static Tribe ghoulTribe;
        public static Tribe giantTribe;
        public static Tribe gooTribe;
        public static Tribe rockTribe;
        public static Tribe seaserpentTribe;
        public static Tribe vampireTribe;
        public static Tribe eggTribe;
        public static Tribe hauntedTribe;
        public static Tribe humanoidTribe;
        public static Tribe instrumentTribe;
        public static Tribe moonTribe;
        public static Tribe occultistTribe;
        public static Tribe possessedTribe;
        public static Tribe spiritTribe;
        public static Tribe unicellularTribe;
        public static Tribe zombieTribe;
        public static Tribe corpseTribe;
        public static Tribe mulluskTribe;
        public static Tribe cryptidTribe;

        public void Awake()
        {
            Logger.LogInfo($"Sucsessfully Loaded {PluginName}!");
            {

                skeletalTribe = TribeManager.Add(
                    PluginGuid,
                    "skeletal",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_skeletal.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_skeletal.png")
                 );
            }
            {
                fleshyTribe = TribeManager.Add(
                    PluginGuid,
                    "fleshy",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fleshy.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_fleshy.png")
                 );
            }
            {
                spectralTribe = TribeManager.Add(
                    PluginGuid,
                    "spectral",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spectral.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_spectral.png")
                 );
            }
            {
                vesselTribe = TribeManager.Add(
                    PluginGuid,
                    "vessel",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_vessel.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_vessel.png")
                 );
            }
            {
                conduitsTribe = TribeManager.Add(
                    PluginGuid,
                    "conduits",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_conduits.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_conduits.png")
                 );
            }
            {
                cellsTribe = TribeManager.Add(
                    PluginGuid,
                    "cells",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cells.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_cells.png")
                 );
            }
            {
                utillityTribe = TribeManager.Add(
                    PluginGuid,
                    "utillity",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_utillity.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_utillity.png")
                 );
            }
            {
                securityTribe = TribeManager.Add(
                    PluginGuid,
                    "security",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_security.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_security.png")
                 );
            }
            {
                scholarTribe = TribeManager.Add(
                    PluginGuid,
                    "scholar",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_scholar.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_scholar.png")
                 );
            }
            {
                guardianTribe = TribeManager.Add(
                    PluginGuid,
                    "guardian",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_guardian.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_guardian.png")
                 );
            }
            {
                moxTribe = TribeManager.Add(
                    PluginGuid,
                    "mox",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mox.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_mox.png")
                 );
            }
            {
                tentacleTribe = TribeManager.Add(
                    PluginGuid,
                    "tentacle",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_tentacle.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_tentacle.png")
                 );
            }
            {
                everythingTribe = TribeManager.Add(
                    PluginGuid,
                    "everything",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_everything.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_everything.png")
                 );
            }
            {
                fungusTribe = TribeManager.Add(
                    PluginGuid,
                    "fungus",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fungus.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_fungus.png")
                 );
            }
            {
                rodentTribe = TribeManager.Add(
                    PluginGuid,
                    "rodent",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_rodent.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_rodent.png")
                 );
            }
            {
                ceromorphTribe = TribeManager.Add(
                    PluginGuid,
                    "ceromorph",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ceromorph.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_ceromorph.png")
                 );
            }
            {
                dragonTribe = TribeManager.Add(
                    PluginGuid,
                    "dragon",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_dragon.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_dragon.png")
                 );
            }
            {
                beastTribe = TribeManager.Add(
                    PluginGuid,
                    "beast",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_beast.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_beast.png")
                 );
            }
            {
                beastwarriorTribe = TribeManager.Add(
                    PluginGuid,
                    "beastwarrior",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_beastwarrior.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_beastwarrior.png")
                 );
            }
            {
                fishTribe = TribeManager.Add(
                    PluginGuid,
                    "fish",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fish.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_fish.png")
                 );
            }
            {
                aquaTribe = TribeManager.Add(
                    PluginGuid,
                    "aqua",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_aqua.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_aqua.png")
                 );
            }
            {
                fairyTribe = TribeManager.Add(
                    PluginGuid,
                    "fairy",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_fairy.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_fairy.png")
                 );
            }
            {
                plantTribe = TribeManager.Add(
                    PluginGuid,
                    "plant",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_plant.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_plant.png")
                 );
            }
            {
                pyroTribe = TribeManager.Add(
                    PluginGuid,
                    "pyro",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_pyro.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_pyro.png")
                 );
            }
            {
                stoneTribe = TribeManager.Add(
                    PluginGuid,
                    "stone",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_stone.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_stone.png")
                 );
            }
            {
                thunderTribe = TribeManager.Add(
                    PluginGuid,
                    "thunder",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_thunder.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_thunder.png")
                 );
            }
            {
                iceTribe = TribeManager.Add(
                    PluginGuid,
                    "ice",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ice.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_ice.png")
                 );
            }
            {
                abominationTribe = TribeManager.Add(
                    PluginGuid,
                    "abomination",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_abomination.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_abomination.png")
                 );
            }
            {
                abominationTribe = TribeManager.Add(
                    PluginGuid,
                    "cyberse",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cyberse.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_TECH_cyberse.png")
                 );
            }
            {
                dinosaurTribe = TribeManager.Add(
                    PluginGuid,
                    "dinosaur",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_dinosaur.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_dinosaur.png")
                 );
            }
            {
                ghoulTribe = TribeManager.Add(
                    PluginGuid,
                    "ghoul",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_ghost.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_ghost.png")
                 );
            }
            {
                giantTribe = TribeManager.Add(
                    PluginGuid,
                    "giant",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_giant.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_giant.png")
                 );
            }
            {
                gooTribe = TribeManager.Add(
                    PluginGuid,
                    "goo",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_goo.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_goo.png")
                 );
            }
            {
                rockTribe = TribeManager.Add(
                    PluginGuid,
                    "rock",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_rock.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_rock.png")
                 );
            }
            {
                seaserpentTribe = TribeManager.Add(
                    PluginGuid,
                    "seaserpent",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_sea_serpent.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_sea_serpent.png")
                 );
            }
            {
                vampireTribe = TribeManager.Add(
                    PluginGuid,
                    "vampire",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_vampire.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_vampire.png")
                 );
            }
            {
                eggTribe = TribeManager.Add(
                    PluginGuid,
                    "egg",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_egg.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_egg.png")
                 );
            }
            {
                hauntedTribe = TribeManager.Add(
                    PluginGuid,
                    "haunted",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_haunted.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_haunted.png")
                 );
            }
            {
                humanoidTribe = TribeManager.Add(
                    PluginGuid,
                    "humanoid",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_humanoid.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_NATURE_humanoid.png")
                 );
            }
            {
                instrumentTribe = TribeManager.Add(
                    PluginGuid,
                    "instrument",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_instrument.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_instrument.png")
                 );
            }
            {
                moonTribe = TribeManager.Add(
                    PluginGuid,
                    "moon",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_moon.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_moon.png")
                 );
            }
            {
                occultistTribe = TribeManager.Add(
                    PluginGuid,
                    "occultist",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_occultist.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_MAGIKS_occultist.png")
                 );
            }
            {
                possessedTribe = TribeManager.Add(
                    PluginGuid,
                    "possessed",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_possessed.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_possessed.png")
                 );
            }
            {
                spiritTribe = TribeManager.Add(
                    PluginGuid,
                    "spirit",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_spirit.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_spirit.png")
                 );
            }
            {
                unicellularTribe = TribeManager.Add(
                    PluginGuid,
                    "unicellular",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_unicellular.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_BASIC_unicellular.png")
                 );
            }
            {
                zombieTribe = TribeManager.Add(
                    PluginGuid,
                    "zombie",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_zombie.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_zombie.png")
                 );
            }
            {
                corpseTribe = TribeManager.Add(
                    PluginGuid,
                    "corpse",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_corpse.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_corpse.png")
                 );
            }
            {
                mulluskTribe = TribeManager.Add(
                    PluginGuid,
                    "mullusk",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_mullusk.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_mullusk.png")
                 );
            }
            {
                cryptidTribe = TribeManager.Add(
                    PluginGuid,
                    "cryptid",
                    tribeIcon: TextureHelper.GetImageAsTexture("tribeicon_cryptid.png"),
                    appearInTribeChoices: true,
                    choiceCardbackTexture: TextureHelper.GetImageAsTexture("card_rewardback_UNDEAD_cryptid.png")
                 );
            }
        }
    }
}
