using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace IncreaseCropGrowthPhase.Framework
{
    internal class KeyBindConfig
    {
        /// <summary>The button held to grow crops around the player.</summary>
        public KeybindList GrowCropsKey { get; set; } = new KeybindList();

    }
}