using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Armors {
    public partial class Armor : MhwItem, ISlots {
        public Armor(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.armorData[MainWindow.locale][GMD_Name_Index];

        [SortOrder(Set_Group_sortIndex + 1)]
        [DisplayName("Is Permanent")]
        public bool Is_Permanent {
            get => Convert.ToBoolean(Is_Permanent_Raw);
            set => Is_Permanent_Raw = Convert.ToByte(value);
        }

        [SortOrder(Set_Skill_1_sortIndex)]
        [DisplayName(Set_Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Set_Skill_1_button => DataHelper.skillData[MainWindow.locale][Set_Skill_1].ToString();

        [SortOrder(Set_Skill_2_sortIndex)]
        [DisplayName(Set_Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Set_Skill_2_button => DataHelper.skillData[MainWindow.locale][Set_Skill_2].ToString();

        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_1_button => DataHelper.skillData[MainWindow.locale][Skill_1].ToString();

        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_2_button => DataHelper.skillData[MainWindow.locale][Skill_2].ToString();

        [SortOrder(Skill_3_sortIndex)]
        [DisplayName(Skill_3_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_3_button => DataHelper.skillData[MainWindow.locale][Skill_3].ToString();
    }
}