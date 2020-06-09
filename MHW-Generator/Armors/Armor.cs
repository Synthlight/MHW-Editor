using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Armors;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Armors {
    public class Armor : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .am_dat
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Index", typeof(uint), true),
                    new MhwMultiStructData.Entry("Order", typeof(ushort)),
                    new MhwMultiStructData.Entry("Variant", typeof(byte), true, typeof(Variant)),
                    new MhwMultiStructData.Entry("Set (Layered) Id", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Type", typeof(byte), true, typeof(ArmorSetType)),
                    new MhwMultiStructData.Entry("Equip Slot", typeof(byte), true, typeof(ArmorType)),
                    new MhwMultiStructData.Entry("Defense", typeof(ushort)),
                    new MhwMultiStructData.Entry("Model Id 1", typeof(ushort)),
                    new MhwMultiStructData.Entry("Model Id 2", typeof(ushort)),
                    new MhwMultiStructData.Entry("Icon Color", typeof(ushort)),
                    new MhwMultiStructData.Entry("Icon Effect", typeof(byte)),
                    new MhwMultiStructData.Entry("Rarity", typeof(byte)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Fire Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Water Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Ice Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Thunder Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Dragon Res", typeof(sbyte)),
                    new MhwMultiStructData.Entry("Slot Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Slot 1 Size", typeof(byte)),
                    new MhwMultiStructData.Entry("Slot 2 Size", typeof(byte)),
                    new MhwMultiStructData.Entry("Slot 3 Size", typeof(byte)),
                    new MhwMultiStructData.Entry("Set Skill 1", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Set Skill 1 Level", typeof(byte)),
                    new MhwMultiStructData.Entry("Hidden Skill", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Hidden Skill Level", typeof(byte)),
                    new MhwMultiStructData.Entry("Skill 1", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Skill 1 Level", typeof(byte)),
                    new MhwMultiStructData.Entry("Skill 2", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Skill 2 Level", typeof(byte)),
                    new MhwMultiStructData.Entry("Skill 3", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Skill 3 Level", typeof(byte)),
                    new MhwMultiStructData.Entry("Gender", typeof(uint), enumReturn: typeof(Gender)),
                    new MhwMultiStructData.Entry("Set Group", typeof(ushort), true),
                    new MhwMultiStructData.Entry("GMD Name Index", typeof(ushort), true),
                    new MhwMultiStructData.Entry("GMD Description Index", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Is Permanent", typeof(byte), enumReturn: typeof(bool))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Set_Group}|{Variant}|{Type}|{Equip_Slot}")
            };

            return new MultiStruct("Armors", "Armor", new MhwMultiStructData(structs, "am_dat"));
        }
    }
}