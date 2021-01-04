using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp13Param : MhwMultiStructFile<Wp13Param> {
        public partial class Ammo_Shifting {
            public string Name => Wp12Param.GetAmmoShiftingName(Index);
        }

        public partial class Power_Long_Mod_Params {
            public string Name => Wp12Param.GetAmmoShiftingName(Index);
        }
    }
}