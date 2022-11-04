using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;

namespace NoKeepersPassTransition
{
    public class Implementation : MelonMod
    {
        public const string keepersPassTransition = "Design/Transitions/CanyonRoad";


        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
        }
    }
}
