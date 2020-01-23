using System;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, IMhwItem, ISlots {
        public Armor(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData.TryGet(GMD_Name_Index, "Unknown");

        public string Set_Skill_1 {
            get => DataHelper.skillData.TryGet(Set_Skill_1_Raw, Set_Skill_1_Raw.ToString());
            set {
                Set_Skill_1_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Set_Skill_1_Raw));
            }
        }

        public string Set_Skill_2 {
            get => DataHelper.skillData.TryGet(Set_Skill_2_Raw, Set_Skill_2_Raw.ToString());
            set {
                Set_Skill_2_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Set_Skill_2_Raw));
            }
        }

        public string Skill_1 {
            get => DataHelper.skillData.TryGet(Skill_1_Raw, Skill_1_Raw.ToString());
            set {
                Skill_1_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Skill_1_Raw));
            }
        }

        public string Skill_2 {
            get => DataHelper.skillData.TryGet(Skill_2_Raw, Skill_2_Raw.ToString());
            set {
                Skill_2_Raw = DataHelper.skillDataNameLookup[value];
                OnPropertyChanged(nameof(Skill_2_Raw));
            }
        }

        public string Skill_3 {
            get => DataHelper.skillData.TryGet(Skill_3_Raw, Skill_3_Raw.ToString());
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