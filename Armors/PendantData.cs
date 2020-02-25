using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class PendantData : MhwItem {
        public PendantData(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.pendantNames[MainWindow.locale].TryGet(Id);

        [SortOrder(0)]
        [DisplayName("")]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}