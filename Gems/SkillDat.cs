using System;
using System.Collections;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Gems {
    public partial class SkillDat : MhwItem {
        public static readonly SkillDat DEFAULT = new SkillDat(new byte[0], 0);

        public SkillDat(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public Skill Name_ => DataHelper.skillData.TryGet(Id, Skill.DEFAULT);
        public override string Name => "None";
    }

    public class SkillDatSorter : IComparer {
        public static SkillDatSorter instance = new SkillDatSorter();
        public ListSortDirection? direction = ListSortDirection.Ascending;

        public SkillDatSorter() {
        }

        public int Compare(object x, object y) {
            switch (x) {
                case SkillDat x1 when y is SkillDat y1: return x1.Name_.id.CompareTo(y1.Name_.id) * (direction == ListSortDirection.Ascending ? 1 : -1);
                default: throw new Exception("Compared objects are not both SkillDats.");
            }
        }
    }
}