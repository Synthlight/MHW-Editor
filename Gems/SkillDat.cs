using System;
using System.Collections;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class SkillDat : MhwItem {
        public static readonly SkillDat DEFAULT = new SkillDat(new byte[0], 0);

        public SkillDat(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public Skill Name_And_Id => DataHelper.skillData[MainWindow.locale].TryGet(Id, Skill.DEFAULT);
        public override string Name => "None";

        public string Description => DataHelper.skillDataDescriptions[MainWindow.locale].TryGet(Id, "Unknown");
    }

    public class SkillDatSorter : IComparer {
        public static readonly SkillDatSorter INSTANCE = new SkillDatSorter();
        public ListSortDirection? direction = ListSortDirection.Ascending;

        public int Compare(object x, object y) {
            if (x is SkillDat x1 && y is SkillDat y1) {
                var idCompare = x1.Name_And_Id.id.CompareTo(y1.Name_And_Id.id) * (direction == ListSortDirection.Ascending ? 1 : -1);
                var levelCompare = x1.Level.CompareTo(y1.Level) * (direction == ListSortDirection.Ascending ? 1 : -1);

                return idCompare == 0 ? levelCompare : idCompare;
            }

            throw new Exception("Compared objects are not both SkillDats.");
        }
    }
}