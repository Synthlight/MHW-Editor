namespace MHW_Editor.Models {
    public struct Skill {
        public ushort value;
        public string name;
        public bool set;

        public override string ToString() {
            return name;
        }
    }
}