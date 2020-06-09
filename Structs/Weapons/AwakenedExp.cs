using MHW_Editor.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class AwakenedExp : MhwSingleStructFile<AwakenedExp, AwakenedExp.Entries> {
        public partial class Entries {
            [SortOrder(20)]
            public ulong Level => Index;
        }
    }
}