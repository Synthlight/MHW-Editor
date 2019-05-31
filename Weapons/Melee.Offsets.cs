namespace MHW_Editor.Weapons {
    public partial class Melee {
        public override string Name {
            get {
                switch (Offset) { // TODO: Limit to the right file. -_-
                    case 3665: return "Giant Jawblade I";
                    case 3730: return "Giant Jawblade II";
                    case 6395: return "Wyvern Ignition \"Impact\"";
                    case 7760: return "Empress Mace \"Blaze\"";
                    default: return "Unknown";
                }
            }
        }
    }
}