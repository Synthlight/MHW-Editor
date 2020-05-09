using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreak : MhwItem {
        public AwakenedLimitBreak(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.awakeningNames[MainWindow.locale].TryGet((uint) Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.awakeningDescriptions[MainWindow.locale].TryGet((uint) Index);

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}