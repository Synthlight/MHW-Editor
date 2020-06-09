using MHW_Editor.Models;

namespace MHW_Editor.Structs.Gems {
    public partial class DecoLottery : MhwSingleStructFile<DecoLottery, DecoLottery.Entries> {
        public partial class Entries {
            public const int Stream_R6__sortIndex = Grade_9_sortIndex + 10;
            public const int Stream_R8__sortIndex = Stream_R6__sortIndex + 10;
        }
    }
}