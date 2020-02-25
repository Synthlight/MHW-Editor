using System.Collections.Generic;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Weapons;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class EqCrt : MhwItem {
        public static readonly Dictionary<string, Dictionary<byte, IdNamePair<byte>>> categoryLookup = new Dictionary<string, Dictionary<byte, IdNamePair<byte>>>();
        public readonly Dictionary<string, Dictionary<uint, string>> nameLookup = new Dictionary<string, Dictionary<uint, string>>();

        static EqCrt() {
            byte i = 0;
            categoryLookup["armor"] = new Dictionary<byte, IdNamePair<byte>> {
                {i++, "Head"},
                {i++, "Chest"},
                {i++, "Waist"},
                {i++, "Arms"},
                {i++, "Legs"},
                {i, "Charm"}
            };
            i = 0;
            categoryLookup["ot_equip"] = new Dictionary<byte, IdNamePair<byte>> {
                {i++, "Weapon"},
                {i++, "Head"},
                {i, "Body"}
            };
            i = 0;
            categoryLookup["weapon"] = new Dictionary<byte, IdNamePair<byte>> {
                {i++, "Greatsword"},
                {i++, "Sword & Shield"},
                {i++, "Dual Blades"},
                {i++, "Longsword"},
                {i++, "Hammer"},
                {i++, "Hunting Horn"},
                {i++, "Lance"},
                {i++, "Gunlance"},
                {i++, "Switch Axe"},
                {i++, "Charge Blade"},
                {i++, "Insect Glaive"},
                {i++, "Bow"},
                {i++, "Light Bowgun"},
                {i, "Heavy Bowgun"}
            };
            categoryLookup["charm"] = new Dictionary<byte, IdNamePair<byte>> {
                {(byte) 0, "Pendant"}
            };
        }

        public EqCrt(byte[] bytes, ulong offset, string filename) : base(bytes, offset) {
            switch (filename) {
                case "charm":
                    nameLookup = DataHelper.pendantData;
                    break;
                default:
                    nameLookup = new Dictionary<string, Dictionary<uint, string>>();
                    foreach (var lang in Global.LANGUAGES) {
                        nameLookup[lang] = new Dictionary<uint, string>();
                    }

                    break;
            }
        }

        public override string Name => nameLookup[MainWindow.locale].TryGet(Equipment_Id);
    }
}