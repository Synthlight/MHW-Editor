using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Armors;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Armors {
    public class OtomoArmorDat : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .owp_dat
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Set Id", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Equip Slot", typeof(byte), true, typeof(ArmorType)),
                    new MhwMultiStructData.Entry("Is Full Set", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Defense", typeof(uint)),
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Order", typeof(ushort)),
                    new MhwMultiStructData.Entry("Model Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Variant", typeof(uint), enumReturn: typeof(Variant)),
                    new MhwMultiStructData.Entry("Fire Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Water Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Ice Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Thunder Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Dragon Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Unk", typeof(uint)),
                    new MhwMultiStructData.Entry("Set Group", typeof(ushort)),
                    new MhwMultiStructData.Entry("GMD Name Index", typeof(ushort), true),
                    new MhwMultiStructData.Entry("GMD Description Index", typeof(ushort), true)
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Set_Id}|{Variant}|{Equip_Slot}")
            };

            return new MultiStruct("MHW_Editor.Armors", "OtomoArmorDat", new MhwMultiStructData(structs, "owp_dat"));
        }
    }
}