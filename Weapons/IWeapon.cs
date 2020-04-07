using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public interface IWeapon : IMhwItem {
        ushort Damage { get; set; }
        uint Cost { get; set; }
        ushort Id { get; set; }
        ushort GMD_Name_Index { get; set; }
    }
}