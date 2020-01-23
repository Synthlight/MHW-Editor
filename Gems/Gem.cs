using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem, IMhwItem {
        public Gem(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name {
            get {
                if (Skill_2_Raw != 0) {
                    return $"{Skill_1} / {Skill_2}";
                } else {
                    return Skill_1;
                }
            }
        }

        public string Skill_1 {
            get => DataHelper.skillData.TryGet(Skill_1_Raw, new Skill {name = Skill_1_Raw.ToString()}).name;
            set {
                Skill_1_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Skill_1_Raw));
            }
        }

        public string Skill_2 {
            get => DataHelper.skillData.TryGet(Skill_2_Raw, new Skill {name = Skill_2_Raw.ToString()}).name;
            set {
                Skill_2_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Skill_2_Raw));
            }
        }
    }
}