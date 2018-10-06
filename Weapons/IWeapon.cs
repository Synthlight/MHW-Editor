namespace MHW_Weapon_Editor.Weapons {
    public interface IWeapon : IMhwItem {
        byte Slots { get; set; }
        byte Slot1Size { get; set; }
        byte Slot2Size { get; set; }
        byte Slot3Size { get; set; }
    }
}