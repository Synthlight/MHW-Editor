using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class ASkill : MhwItem {
        public ASkill(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.mantleData[MainWindow.locale].TryGet((ushort) Index);

        [SortOrder(lastSortIndex + 1)]
        public string Description => DataHelper.mantleDataDescriptions[MainWindow.locale].TryGet((ushort) Index);

        [SortOrder(0)]
        [DisplayName("")]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}