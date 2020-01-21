namespace MHW_Editor.Gems {
    public partial class Gem {
        public override string Name {
            get {
                if (Skill_2_Raw != 0) {
                    return $"{Skill_1} / {Skill_2}";
                } else {
                    return Skill_1;
                }
            }
        }
    }
}