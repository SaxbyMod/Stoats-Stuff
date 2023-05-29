using BepInEx;
using DiskCardGame;
using ExampleMod.Classes;
using HarmonyLib;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        Harmony harmony = new Harmony(PluginGuid);

        // These are variables that exist everywhere in the entire class.
        private const string PluginGuid = "creator.TooManySigils";
        private const string PluginName = "TooManySigils";
        private const string PluginVersion = "1.1.0";
        private const string PluginPrefix = "Too Many Sigils";

        // For some things, like challenge icons, we need to add the art now instead of later.
        // We initialize the list here, in Awake() we'll add the sprites themselves.
        public static List<Sprite> art_sprites;

        // This is where you would run all of your other methods.
        private void Awake()
        {
            Logger.LogInfo($"Loaded {PluginName}!");

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            // Here we add the sprites to the list we created earlier.
            art_sprites = new List<Sprite>();

            // Add abilities before cards. Otherwise, the game will try to load cards before the abilities are created.

            // The example ability method.
            AddDeadPack();
            AddHeartlocked();
            AddThickshell();
            AddSpawner();
            AddLauncher();
            AddHost();
            AddBastion();
        }

        // This method passes the ability and the ability information to the API.
        private void AddDeadPack()
        {
            // This builds our ability information.
            AbilityInfo deadpack = AbilityManager.New(
                PluginGuid,
                "DeadPack",
                "When a card bearing this sigil perishes, it provides 1 Item to its owner.",
                typeof(DeadDraw.DeathDraw),
                "Dead_Draw_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Test_Icon_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            DeadDraw.DeathDraw.ability = deadpack.ability;
        }
        private void AddHeartlocked()
        {
            // This builds our ability information.
            AbilityInfo Heartlocked = AbilityManager.New(
                PluginGuid,
                "Heart Locked",
                "When a card bearing this sigil is damaged, It only takes 1 Damage.",
                typeof(HeartLocked),
                "Resistant_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Resistant_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            HeartLocked.ability = Heartlocked.ability;
        }
        private void AddThickshell()
        {
            // This builds our ability information.
            AbilityInfo thickshell = AbilityManager.New(
                PluginGuid,
                "Thick Shell",
                "When a card bearing this sigil is damaged, It takes 1 less Damage.",
                typeof(Thickshell),
                "Thick_Shell_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Thick_Shell_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Thickshell.ability = thickshell.ability;
        }
        private void AddLauncher()
        {
            // This builds our ability information.
            AbilityInfo launcher = AbilityManager.New(
                PluginGuid,
                "Launcher",
                "If a card bearing this sigil is on the field during your endstep, a card is launched to one of your empty spaces.",
                typeof(Launcher),
                "Launcher_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Launcher_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Launcher.ability = launcher.ability;
        }
        private void AddSpawner()
        {
            // This builds our ability information.
            AbilityInfo spawner = AbilityManager.New(
                PluginGuid,
                "Spawner",
                "If a card bearing this sigil is on field during your endstep, this card moves in the direction inscribed in the sigil, and a card is played in its previous space.",
                typeof(Spawner),
                "Spawner_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Spawner_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Spawner.ability = spawner.ability;
        }
        private void AddHost()
        {
            // This builds our ability information.
            AbilityInfo host = AbilityManager.New(
                PluginGuid,
                "Host",
                "When a card bearing this sigil is damaged, a card is added to your hand.",
                typeof(Host),
                "Host_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Host_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Host.ability = host.ability;
        }
        private void AddBastion()
        {
            // This builds our ability information.
            AbilityInfo bastion = AbilityManager.New(
                PluginGuid,
                "Bastion",
                "When this card is damaged, It takes half the Damage it would normally.",
                typeof(Bastion),
                "Bastion_A1.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Bastion_A2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Bastion.ability = bastion.ability;
        }
    }
}
