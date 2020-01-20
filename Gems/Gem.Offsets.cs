namespace MHW_Editor.Gems {
    public partial class Gem {
        public override string Name {
            get {
                if (Skill2 != "0") {
                    return Skill1 + " / " + Skill2;
                } else {
                    return Skill1;
                }
            }
        }
    }
}