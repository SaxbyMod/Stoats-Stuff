﻿using DiskCardGame;
using System.Collections;
using UnityEngine;

namespace ExampleMod.Classes
{
    internal class Lose1Battery : AbilityBehaviour
    {
        public override Ability Ability
        {
            get
            {
                return ability;
            }
        }

        public static Ability ability;

        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }
        public override IEnumerator OnResolveOnBoard()
        {
            yield return base.PreSuccessfulTriggerSequence();
            if (Singleton<ResourcesManager>.Instance is Part3ResourcesManager)
            {
                yield return new WaitForSeconds(0.2f);
                Singleton<ViewManager>.Instance.SwitchToView(View.Default, false, false);
                yield return new WaitForSeconds(0.2f);
            }
            yield return Singleton<ResourcesManager>.Instance.AddMaxEnergy(-1);
            yield return Singleton<ResourcesManager>.Instance.AddEnergy(-1);
            if (Singleton<ResourcesManager>.Instance is Part3ResourcesManager)
            {
                yield return new WaitForSeconds(0.3f);
            }
            yield return base.LearnAbility(0.2f);
            yield break;
        }
    }
}