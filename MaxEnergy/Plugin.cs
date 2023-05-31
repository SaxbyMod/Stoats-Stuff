using BepInEx;
using DiskCardGame;
using ExampleMod.Classes;
using HarmonyLib;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // Declare Harmony here for future Harmony patches. You'll use Harmony to patch the game's code outside of the scope of the API.
        Harmony harmony = new Harmony(PluginGuid);

        // These are variables that exist everywhere in the entire class.
        private const string PluginGuid = "creator.max";
        private const string PluginName = "Max Energy Mod";
        private const string PluginVersion = "1.0.0";
        private const string PluginPrefix = "Test";

        // For some things, like challenge icons, we need to add the art now instead of later.
        // We initialize the list here, in Awake() we'll add the sprites themselves.
        public static List<Sprite> art_sprites;

        // --------------------------------------------------------------------------------------------------------------------------------------------------

        // This is where you would run all of your other methods.
        private void Awake()
        {
            Logger.LogInfo($"Loaded {PluginName}!");

            // Apply our harmony patches.
            harmony.PatchAll(typeof(Plugin));

            // Here we add the sprites to the list we created earlier.
            art_sprites = new List<Sprite>();

            AddLoseBattery();
            AddTestCard();
            AddLoseBattery2();
            AddLoseBattery3();
            AddLoseBattery4();
            AddLoseBattery5();
            AddLoseBattery6();
            AddGainBattery();
            AddGainBattery2();
            AddGainBattery3();
            AddGainBattery4();
            AddGainBattery5();
            AddGainBattery6();
        }

        private void AddLoseBattery()
        {
            // This builds our ability information.
            AbilityInfo losebattery = AbilityManager.New(
                PluginGuid,
                "Lose One Battery",
                "When a card bearing this sigil is played, the owner loses one Max Energy.",
                typeof(Lose1Battery),
                "Lose1Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Lose1Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Lose1Battery.ability = losebattery.ability;
        }
        private void AddLoseBattery2()
        {
            // This builds our ability information.
            AbilityInfo lose2battery = AbilityManager.New(
                PluginGuid,
                "Lose Two Batteries",
                "When a card bearing this sigil is played, the owner loses two Max Energy.",
                typeof(Lose2Battery),
                "Lose2Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Lose2Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Lose2Battery.ability = lose2battery.ability;
        }
        private void AddLoseBattery3()
        {
            // This builds our ability information.
            AbilityInfo lose3battery = AbilityManager.New(
                PluginGuid,
                "Lose Three Batteries",
                "When a card bearing this sigil is played, the owner loses three Max Energy.",
                typeof(Lose3Battery),
                "Lose3Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Lose3Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Lose3Battery.ability = lose3battery.ability;
        }
        private void AddLoseBattery4()
        {
            // This builds our ability information.
            AbilityInfo lose4battery = AbilityManager.New(
                PluginGuid,
                "Lose Four Batteries",
                "When a card bearing this sigil is played, the owner loses four Max Energy.",
                typeof(Lose4Battery),
                "Lose4Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Lose4Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Lose4Battery.ability = lose4battery.ability;
        }
        private void AddLoseBattery5()
        {
            // This builds our ability information.
            AbilityInfo lose5battery = AbilityManager.New(
                PluginGuid,
                "Lose Five Batteries",
                "When a card bearing this sigil is played, the owner loses five Max Energy.",
                typeof(Lose5Battery),
                "Lose5Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Lose5Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Lose5Battery.ability = lose5battery.ability;
        }
        private void AddLoseBattery6()
        {
            // This builds our ability information.
            AbilityInfo lose6battery = AbilityManager.New(
                PluginGuid,
                "Lose Six Batteries",
                "When a card bearing this sigil is played, the owner loses six Max Energy.",
                typeof(Lose6Battery),
                "Lose6Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Lose6Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Lose6Battery.ability = lose6battery.ability;
        }
        private void AddGainBattery()
        {
            // This builds our ability information.
            AbilityInfo gain1battery = AbilityManager.New(
                PluginGuid,
                "Gain One Battery",
                "When a card bearing this sigil is played, the owner gains one Max Energy.",
                typeof(Gain1Battery),
                "Gain1Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Gain1Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Gain1Battery.ability = gain1battery.ability;
        }
        private void AddGainBattery2()
        {
            // This builds our ability information.
            AbilityInfo gain2battery = AbilityManager.New(
                PluginGuid,
                "Gain Two Batteries",
                "When a card bearing this sigil is played, the owner gains two Max Energy.",
                typeof(Gain2Battery),
                "Gain2Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Gain2Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Gain2Battery.ability = gain2battery.ability;
        }
        private void AddGainBattery3()
        {
            // This builds our ability information.
            AbilityInfo gain3battery = AbilityManager.New(
                PluginGuid,
                "Gain Three Batteries",
                "When a card bearing this sigil is played, the owner gains three Max Energy.",
                typeof(Gain3Battery),
                "Gain3Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Gain3Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Gain3Battery.ability = gain3battery.ability;
        }
        private void AddGainBattery4()
        {
            // This builds our ability information.
            AbilityInfo gain4battery = AbilityManager.New(
                PluginGuid,
                "Gain Four Batteries",
                "When a card bearing this sigil is played, the owner gains four Max Energy.",
                typeof(Gain4Battery),
                "Gain4Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Gain4Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Gain4Battery.ability = gain4battery.ability;
        }
        private void AddGainBattery5()
        {
            // This builds our ability information.
            AbilityInfo gain5battery = AbilityManager.New(
                PluginGuid,
                "Gain Five Batteries",
                "When a card bearing this sigil is played, the owner gains five Max Energy.",
                typeof(Gain5Battery),
                "Gain5Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Gain5Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Gain5Battery.ability = gain5battery.ability;
        }
        private void AddGainBattery6()
        {
            // This builds our ability information.
            AbilityInfo gain6battery = AbilityManager.New(
                PluginGuid,
                "Gain Six Batteries",
                "When a card bearing this sigil is played, the owner gains six Max Energy.",
                typeof(Gain6Battery),
                "Gain6Battery.png"
            )

            // This ability will show up in the Part 1 rulebook and can appear on cards in Part 1.
            .SetDefaultPart1Ability()

            // This specifies the icon for the ability if it exists in Part 2.
            .SetPixelAbilityIcon(TextureHelper.GetImageAsTexture("Gain6Battery_a2.png"), FilterMode.Point)

            //Adds all rulebook metacategories
            .AddMetaCategories(AbilityMetaCategory.Part1Rulebook, AbilityMetaCategory.Part3Rulebook, AbilityMetaCategory.GrimoraRulebook, AbilityMetaCategory.MagnificusRulebook);

            // Pass the ability to the API.
            Gain6Battery.ability = gain6battery.ability;
        }
        private void AddTestCard()
        {
            CardInfo Test = CardManager.New(

                // Card ID Prefix
                modPrefix: "Test",
                // Card internal name
                "Test",
                // Displayed Name
                "Test",
                // Attack.
                0,
                // Health.
                3
            )
            .SetCost(energyCost: 1)
            .AddAbilities(Lose1Battery.ability)
            .SetDefaultPart1Card();
            CardManager.Add("Test", Test);
        }
    }
}
