using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class CustomPartsR : MhwItem {
        public CustomPartsR(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.customPartsRecipeNames[MainWindow.locale].TryGet((uint) Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.customPartsRecipeDescriptions[MainWindow.locale].TryGet((uint) Index);

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}