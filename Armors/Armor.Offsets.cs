namespace MHW_Editor.Armors {
    public partial class Armor {
        public override string Name {
            get {
                switch (Index) {
                    case 122: return "Guild Cross Alpha";
                    case 123: return "Guild Cross Beta";
                    case 136: return "Dragon King Eyepatch";
                    case 138: return "Xeno'Jiiva Alpha";
                    case 139: return "Xeno'Jiiva Beta";
                    default: return "Unknown";
                }
            }
        }
    }
}