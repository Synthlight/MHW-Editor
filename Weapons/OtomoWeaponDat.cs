using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class OtomoWeaponDat : MhwItem {
        public OtomoWeaponDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "Not Yet"; // TODO: Extract otomo GMD files.
    }
}