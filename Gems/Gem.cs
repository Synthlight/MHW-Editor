using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem, IMhwItem {
        public Gem(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData.TryGet((uint) (Id * 2), "Unknown");

        public string Skill_1 {
            get => DataHelper.skillData.TryGet(Skill_1_Raw, Skill_1_Raw.ToString());
            set {
                Skill_1_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Skill_1_Raw));
            }
        }

        public string Skill_2 {
            get => DataHelper.skillData.TryGet(Skill_2_Raw, Skill_2_Raw.ToString());
            set {
                Skill_2_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Skill_2_Raw));
            }
        }
    }
}