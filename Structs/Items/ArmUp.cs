using MHW_Editor.Models;

namespace MHW_Editor.Structs.Items {
    public partial class ArmUp : MhwSingleStructFile<ArmUp, ArmUp.Entries> {
        public partial class Entries {
            [SortOrder(20)]
            public ulong Rarity => Index;
        }
    }
}