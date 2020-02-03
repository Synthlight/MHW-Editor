using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;

namespace MHW_Editor.Items {
    public partial class EqCrt : MhwItem {
        public static readonly Dictionary<string, Dictionary<byte, IdNamePair>> categoryLookup = new Dictionary<string, Dictionary<byte, IdNamePair>>();

        static EqCrt() {
            byte i = 0;
            categoryLookup["armor"] = new Dictionary<byte, IdNamePair> {
                {i, new IdNamePair(i++, "Head")},
                {i, new IdNamePair(i++, "Chest")},
                {i, new IdNamePair(i++, "Waist")},
                {i, new IdNamePair(i++, "Arms")},
                {i, new IdNamePair(i++, "Legs")},
                {i, new IdNamePair(i, "Charm")}
            };
            i = 0;
            categoryLookup["ot"] = new Dictionary<byte, IdNamePair> {
                {i, new IdNamePair(i++, "Weapon")},
                {i, new IdNamePair(i++, "Head")},
                {i, new IdNamePair(i, "Body")}
            };
            i = 0;
            categoryLookup["weapon"] = new Dictionary<byte, IdNamePair> {
                {i, new IdNamePair(i++, "Greatsword")},
                {i, new IdNamePair(i++, "Sword & Shield")},
                {i, new IdNamePair(i++, "Dual Blades")},
                {i, new IdNamePair(i++, "Longsword")},
                {i, new IdNamePair(i++, "Hammer")},
                {i, new IdNamePair(i++, "Hunting Horn")},
                {i, new IdNamePair(i++, "Lance")},
                {i, new IdNamePair(i++, "Gunlance")},
                {i, new IdNamePair(i++, "Switch Axe")},
                {i, new IdNamePair(i++, "Charge Blade")},
                {i, new IdNamePair(i++, "Insect Glaive")},
                {i, new IdNamePair(i++, "Bow")},
                {i, new IdNamePair(i++, "Light Bowgun")},
                {i, new IdNamePair(i, "Heavy Bowgun")}
            };
        }

        public EqCrt(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        [SortOrder(Mat_1_Id_sortIndex)]
        [DisplayName(Mat_1_Id_displayName)]
        public string Mat_1_Id_button => DataHelper.itemData[MainWindow.locale][Mat_1_Id].ToString();

        [SortOrder(Mat_2_Id_sortIndex)]
        [DisplayName(Mat_2_Id_displayName)]
        public string Mat_2_Id_button => DataHelper.itemData[MainWindow.locale][Mat_2_Id].ToString();

        [SortOrder(Mat_3_Id_sortIndex)]
        [DisplayName(Mat_3_Id_displayName)]
        public string Mat_3_Id_button => DataHelper.itemData[MainWindow.locale][Mat_3_Id].ToString();

        [SortOrder(Mat_4_Id_sortIndex)]
        [DisplayName(Mat_4_Id_displayName)]
        public string Mat_4_Id_button => DataHelper.itemData[MainWindow.locale][Mat_4_Id].ToString();
    }
}