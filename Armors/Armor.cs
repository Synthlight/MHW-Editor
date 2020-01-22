using System;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, IMhwItem, ISlots {
        public Armor(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData.TryGet(Set_Id, "Unknown");

        public string Set_Skill_1 {
            get => DataHelper.skillData.TryGet(Set_Skill_1_Raw, new Skill {name = Set_Skill_1_Raw.ToString()}).name;
            set {
                Set_Skill_1_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Set_Skill_1_Raw));
            }
        }

        public string Set_Skill_2 {
            get => DataHelper.skillData.TryGet(Set_Skill_2_Raw, new Skill {name = Set_Skill_2_Raw.ToString()}).name;
            set {
                Set_Skill_2_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Set_Skill_2_Raw));
            }
        }

        public string Skill_1 {
            get => DataHelper.skillData.TryGet(Skill_1_Raw, new Skill {name = Skill_1_Raw.ToString()}).name;
            set {
                Skill_1_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Skill_1_Raw));
            }
        }

        public string Skill_2 {
            get => DataHelper.skillData.TryGet(Skill_2_Raw, new Skill {name = Skill_2_Raw.ToString()}).name;
            set {
                Skill_2_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Skill_2_Raw));
            }
        }

        public string Skill_3 {
            get => DataHelper.skillData.TryGet(Skill_3_Raw, new Skill {name = Skill_3_Raw.ToString()}).name;
            set {
                Skill_3_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Skill_3_Raw));
            }
        }

        public bool Is_Permanent {
            get => Convert.ToBoolean(Is_Permanent_Raw);
            set => Is_Permanent_Raw = Convert.ToByte(value);
        }
    }
}