using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public abstract partial class EqCrt_Base : MhwItem {
        protected EqCrt_Base(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";
    }
}