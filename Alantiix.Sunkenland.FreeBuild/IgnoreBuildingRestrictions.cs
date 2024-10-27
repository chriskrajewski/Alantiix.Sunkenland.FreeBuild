using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace Alantiix.Sunkenland.FreeBuild
{
    [BepInPlugin("com.alantiix.freebuild", "Alantiix Ignore Building Restrictions", "1.0.0")]
    public class IgnoreBuildingRestrictions : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony harmony = new Harmony("com.alantiix.freebuild");
            harmony.PatchAll();
        }
    }
}
