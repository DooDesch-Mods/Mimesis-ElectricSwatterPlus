namespace DooDesch.Weapons
{
    internal static class WeaponDefinition
    {
        internal const string Name = "ElectricSwatterPlus";
        internal static readonly int ItemId = 2040;
        internal static bool IsGun => false;
        internal static bool IsBat => false;
        internal static bool IsReload(int skill) => false;
        internal static bool HasSkill(int skill) => skill == 10850 || skill == 10860;
    }
}
