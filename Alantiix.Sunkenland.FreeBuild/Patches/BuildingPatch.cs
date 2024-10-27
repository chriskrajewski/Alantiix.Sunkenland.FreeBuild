using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;


namespace Alantiix.Sunkenland.FreeBuild.Patches
{

    [HarmonyPatch(typeof(BuildingHelpers), "get_PlacementAllowed")]
    class BuildingHelpersPlacementAllowedPatch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true; 
            return false;    
        }
    }
}


