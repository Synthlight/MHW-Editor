namespace MHW_Weapon_Editor.Weapons {
    public partial class Melee {
        public override string Name {
            get {
                switch (Offset) {
                    case 6395: return "Wyvern Ignition \"Impact\"";
                    default: return "Unknown";
                }
            }
        }
    }
}