using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public interface IWeapon : IMhwItem {
        ushort Damage { get; set; }
        uint Cost { get; set; }
    }
}