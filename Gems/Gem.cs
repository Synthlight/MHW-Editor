using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class Gem : MhwItem {
        public Gem(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale].TryGet(Id, IdNamePair.Unknown(Id)).name;

        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_1_button => DataHelper.skillData[MainWindow.locale].TryGet(Skill_1, IdNamePair.Unknown(Skill_1)).ToString();

        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter), true)]
        public string Skill_2_button => DataHelper.skillData[MainWindow.locale].TryGet(Skill_2, IdNamePair.Unknown(Skill_2)).ToString();
    }
}