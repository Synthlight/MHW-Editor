using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class CustomParts : MhwItem {
        public CustomParts(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.customPartsNames[MainWindow.locale].TryGet((uint) Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.customPartsDescriptions[MainWindow.locale].TryGet((uint) Index);

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}