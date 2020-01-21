using MHW_Editor.Gems;

namespace MHW_Editor.Weapons {
    public partial class Ranged : MhwItem, ISlots {
        public Ranged(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public sbyte Affinity {
            get => Affinity_Raw;
            set => Affinity_Raw = value.Clamp((sbyte) -100, (sbyte) 100);
        }

        public string Skill {
            get => DataHelper.skillData.TryGet(Skill_Raw, new Skill {name = Skill_Raw.ToString()}).name;
            set {
                Skill_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Skill_Raw));
            }
        }
    }
}