using System;
using System.Collections;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class SkillDat : MhwItem {
        public static readonly SkillDat DEFAULT = new SkillDat(new byte[0], 0);

        public SkillDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("Name/Id")]
        public Skill Name_And_Id => DataHelper.skillData[MainWindow.locale].TryGet(Id, Skill.DEFAULT);

        public override string Name => "None";

        public string Description => DataHelper.skillDataDescriptions[MainWindow.locale].TryGet(Id, "Unknown");
    }

    public class SkillDatSorter : IComparer {
        public static readonly SkillDatSorter INSTANCE = new SkillDatSorter();
        public ListSortDirection? direction = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SkillDat x1 && y is SkillDat x2) {
                if (MainWindow.showSkillIdFirst) {
                    var idCompare = x1.Name_And_Id.id.CompareTo(x2.Name_And_Id.id) * (direction == ListSortDirection.Ascending ? 1 : -1);
                    var levelCompare = x1.Level.CompareTo(x2.Level) * (direction == ListSortDirection.Ascending ? 1 : -1);

                    return idCompare == 0 ? levelCompare : idCompare;
                } else {
                    var nameCompare = string.Compare(x1.Name_And_Id.name, x2.Name_And_Id.name, StringComparison.Ordinal) * (direction == ListSortDirection.Ascending ? 1 : -1);
                    var levelCompare = x1.Level.CompareTo(x2.Level) * (direction == ListSortDirection.Ascending ? 1 : -1);

                    return nameCompare == 0 ? levelCompare : nameCompare;
                }
            }

            //if (x is Gem y1 && y is Gem y2) {
            //    if (MainWindow.showSkillIdFirst) {
            //        return y1.Id.CompareTo(y2.Id) * (direction == ListSortDirection.Ascending ? 1 : -1);
            //    } else {
            //        return string.Compare(DataHelper.skillData[MainWindow.locale][y1.Skill_1].name, DataHelper.skillData[MainWindow.locale][y2.Skill_1].name, StringComparison.OrdinalIgnoreCase) * (direction == ListSortDirection.Ascending ? 1 : -1);
            //    }
            //}

            return 0;
        }
    }
}