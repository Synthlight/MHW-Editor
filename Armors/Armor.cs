using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, ISlots {
        public Armor(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Name_Index, "Unknown");

        [SortOrder(lastSortIndex + 1)]
        [DisplayName("Description")]
        public string Description => DataHelper.armorData[MainWindow.locale].TryGet(GMD_Description_Index, "Unknown").Replace("\r\n", " ");

        [SortOrder(Set_Group_sortIndex + 1)]
        [DisplayName("Is Permanent")]
        public bool Is_Permanent {
            get => Convert.ToBoolean(Is_Permanent_Raw);
            set {
                Is_Permanent_Raw = Convert.ToByte(value);
                OnPropertyChanged(nameof(Is_Permanent));
            }
        }

        [SortOrder(Set_Skill_1_sortIndex)]
        [DisplayName(Set_Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Set_Skill_1_button => DataHelper.skillData[MainWindow.locale].TryGet(Set_Skill_1, IdNamePair.Unknown(Set_Skill_1)).ToString();

        [SortOrder(Set_Skill_2_sortIndex)]
        [DisplayName(Set_Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Set_Skill_2_button => DataHelper.skillData[MainWindow.locale].TryGet(Set_Skill_2, IdNamePair.Unknown(Set_Skill_2)).ToString();

        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_1_button => DataHelper.skillData[MainWindow.locale].TryGet(Skill_1, IdNamePair.Unknown(Skill_1)).ToString();

        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_2_button => DataHelper.skillData[MainWindow.locale].TryGet(Skill_2, IdNamePair.Unknown(Skill_2)).ToString();

        [SortOrder(Skill_3_sortIndex)]
        [DisplayName(Skill_3_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_3_button => DataHelper.skillData[MainWindow.locale].TryGet(Skill_3, IdNamePair.Unknown(Skill_3)).ToString();
    }
}