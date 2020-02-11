using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponWhistle : MhwItem {
        public WeaponWhistle(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}