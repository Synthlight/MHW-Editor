using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem {
        public Gem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale][Id].name;

        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_1_button => DataHelper.skillData[MainWindow.locale][Skill_1].ToString();

        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_2_button => DataHelper.skillData[MainWindow.locale][Skill_2].ToString();
    }
}