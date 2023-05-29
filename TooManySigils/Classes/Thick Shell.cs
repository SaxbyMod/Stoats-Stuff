﻿using DiskCardGame;
using HarmonyLib;

namespace ExampleMod.Classes
{
    public class Thickshell : AbilityBehaviour
    {
        // Token: 0x17000071 RID: 113
        // (get) Token: 0x0600027B RID: 635 RVA: 0x00009971 File Offset: 0x00007B71
        public override Ability Ability
        {
            get
            {
                return Thickshell.ability;
            }
        }

        // Token: 0x040000AA RID: 170
        public static Ability ability;
    }

    [HarmonyPatch(typeof(PlayableCard), "TakeDamage")]
    public class TakeDamagePatch : PlayableCard
    {
        // Token: 0x06000228 RID: 552 RVA: 0x000090AC File Offset: 0x000072AC
        private static void Prefix(ref PlayableCard __instance, ref int damage)
        {
            bool flag2 = __instance.HasAbility(Thickshell.ability);
            if (flag2)
            {
                damage--;
            }
        }
    }
}

