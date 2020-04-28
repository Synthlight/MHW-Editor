using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Gems {
    public partial class DecoLottery : MhwItem {
        public DecoLottery(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";
    }
}