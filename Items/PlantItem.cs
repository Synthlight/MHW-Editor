using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class PlantItem : MhwItem {
        public PlantItem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";
    }
}