namespace MHW_Editor.Weapons {
    public partial class Melee {
        public override string Name {
            get {
                switch (Offset) { // TODO: Limit to the right file. -_-
                    case 6395: return "Wyvern Ignition \"Impact\"";
                    default: return "Unknown";
                }
            }
        }
    }
}