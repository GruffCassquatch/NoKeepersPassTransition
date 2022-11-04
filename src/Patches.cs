using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace NoKeepersPassTransition
{
    public class Patches
    {
        [HarmonyPatch(typeof(GameManager), "Awake")]
        internal class DisableKeepersPassTransition
        {
            private static void Postfix()
            {
                if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "RuralRegion") return;
                if (ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.Story || ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.StoryFresh || ExperienceModeManager.GetCurrentExperienceModeType() == ExperienceModeType.StoryHardened) return;

                GameObject keepersPassTransition = GameObject.Find(Implementation.keepersPassTransition);

                if (keepersPassTransition is null)
                {
                    MelonLoader.MelonLogger.Error("Could not find keepersPassTransition");
                    return;
                }
                else
                {
                    keepersPassTransition.SetActive(false);
                }
            }
        }
    }
}
