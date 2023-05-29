﻿using DiskCardGame;
using HarmonyLib;

namespace ExampleMod.Classes
{
    public class HeartLocked : AbilityBehaviour
    {
        public override Ability Ability
        {
            get
            {
                return HeartLocked.ability;
            }
        }

        public static Ability ability;

        [HarmonyPatch(typeof(PlayableCard), "TakeDamage")]
        public class TakeDamagePatch : PlayableCard
        {
            // Token: 0x06000228 RID: 552 RVA: 0x000090AC File Offset: 0x000072AC
            private static void Prefix(ref PlayableCard __instance, ref int damage)
            {
                bool flag = __instance.HasAbility(HeartLocked.ability);
                if (flag)
                {
                    damage = 1;
                }
            }
        }
    }
}
