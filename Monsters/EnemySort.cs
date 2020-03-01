using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monsters {
    public partial class EnemySort : MhwItem {
        public EnemySort(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Index => (Offset - InitialOffset) / StructSize;
    }
}