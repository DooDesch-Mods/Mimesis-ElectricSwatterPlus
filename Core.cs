using MelonLoader;
using DooDesch.Weapons;

[assembly: MelonInfo(typeof(ElectricSwatterPlus.Core), "ElectricSwatterPlus", DooDesch.ModVersion.Current, "DooDesch", null)]
[assembly: MelonGame("ReLUGames", "MIMESIS")]

namespace ElectricSwatterPlus
{
    public sealed class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            WeaponPreferences.Initialize();
            MelonLogger.Msg("ElectricSwatterPlus initialized for item 2040. Gameplay follows the host.");
        }
        public override void OnUpdate()
        {
            DooDesch.HostSettings.Update();
            WeaponDisplay.Update();
            WeaponReloadAnimation.Update();
        }
    }
}
