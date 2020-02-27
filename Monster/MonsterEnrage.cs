using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Monster {
    public partial class MonsterEnrage : MhwItem, IHasCustomView<PlDataItemCustomView> {
        public MonsterEnrage(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";
    }
}