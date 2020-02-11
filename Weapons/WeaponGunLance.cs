using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponGunLance : MhwItem {
        public WeaponGunLance(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string UniqueId => $"{Id}";

        public override string Name => "None";
    }
}