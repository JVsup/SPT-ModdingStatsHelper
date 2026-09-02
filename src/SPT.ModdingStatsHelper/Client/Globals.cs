using EFT.InventoryLogic;
using EFT.UI;
using System.Collections.Generic;

namespace SPT.ModdingStatsHelper
{
    public static class Globals
    {
        public static bool isWeaponModding = false;

        public static Item mod = null;

        public static List<Slot> allSlots = new List<Slot>();

        public static SimpleTooltip simpleTooltip = null;

        public static string lastTooltipText = "";

        public static Item dropDownCurrentItem = null;

        public static bool isKeyPressed = false;

        // Some stats are not very interesting to see and will clog up the UI more than anything,
        // so we blacklist them.
        public static string[] statBlacklist = {
            EItemAttributeId.CompatibleWith.ToString(),
            EItemAttributeId.Weight.ToString(),
            EItemAttributeId.Size.ToString(),
            EItemAttributeId.RaidModdable.ToString(),
            EItemAttributeId.OpticCrate.ToString(),
            EItemAttributeId.SightingRange.ToString(),
            EItemAttributeId.SingleFireRate.ToString(),
            EItemAttributeId.FireRate.ToString(),
            EItemAttributeId.DurabilityBurn.ToString(),
            EItemAttributeId.HeatFactor.ToString(),
            EItemAttributeId.CoolFactor.ToString(),
            EItemAttributeId.MalfFeedChance.ToString(),
            EItemAttributeId.MalfMisfireChance.ToString(),
            EItemAttributeId.LoadUnloadSpeed.ToString(),
            EItemAttributeId.CheckTimeSpeed.ToString(),
            "AutoROF",
            "SemiROF",
        };

        public static void ClearAllGlobals()
        {
            isWeaponModding = false;
            mod = null;
            allSlots.Clear();
            simpleTooltip = null;
            dropDownCurrentItem = null;
            lastTooltipText = "";
            isKeyPressed = false;
        }
    }
}
