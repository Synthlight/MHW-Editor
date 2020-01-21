namespace MHW_Editor.Gems {
    public struct Skill {
        public ushort value;
        public string name;
        public bool set;

        public override string ToString() {
            return name;
        }
    }
}