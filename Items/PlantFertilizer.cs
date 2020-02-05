using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class PlantFertilizer : MhwItem {
        public PlantFertilizer(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";
    }
}