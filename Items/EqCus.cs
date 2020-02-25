using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class EqCus : MhwItem {
        public EqCus(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";
    }
}