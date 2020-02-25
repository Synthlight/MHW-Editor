using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class CustomPartsR : MhwItem {
        public CustomPartsR(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";
    }
}