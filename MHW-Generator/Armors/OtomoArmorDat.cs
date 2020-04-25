using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Armors;

namespace MHW_Generator.Armors {
    public class OtomoArmorDat : ISingleStruct {
        public SingleStruct Generate() { // .owp_dat
            return new SingleStruct("MHW_Editor.Armors", "OtomoArmorDat", new MhwStructData {
                size = 42,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Set_Id}|{Variant}|{Equip_Slot}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Set Id", 4, typeof(ushort), true),
                    new MhwStructData.Entry("Equip Slot", 6, typeof(byte), true, typeof(ArmorType)),
                    new MhwStructData.Entry("Is Full Set", 7, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Defense", 8, typeof(uint)),
                    new MhwStructData.Entry("Rarity", 12, typeof(byte)),
                    new MhwStructData.Entry("Order", 13, typeof(ushort)),
                    new MhwStructData.Entry("Model Id", 15, typeof(uint)),
                    new MhwStructData.Entry("Cost", 19, typeof(uint)),
                    new MhwStructData.Entry("Variant", 23, typeof(uint), typeof(Variant)),
                    new MhwStructData.Entry("Fire Res", 27, typeof(sbyte)),
                    new MhwStructData.Entry("Water Res", 28, typeof(sbyte)),
                    new MhwStructData.Entry("Ice Res", 29, typeof(sbyte)),
                    new MhwStructData.Entry("Thunder Res", 30, typeof(sbyte)),
                    new MhwStructData.Entry("Dragon Res", 31, typeof(sbyte)),
                    new MhwStructData.Entry("Unk", 32, typeof(uint)),
                    new MhwStructData.Entry("Set Group", 36, typeof(ushort)),
                    new MhwStructData.Entry("GMD Name Index", 38, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 40, typeof(ushort), true)
                }
            });
        }
    }
}