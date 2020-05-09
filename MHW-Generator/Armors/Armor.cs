using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Armors;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Armors {
    public class Armor : ISingleStruct {
        public SingleStruct Generate() { // .am_dat
            return new SingleStruct("MHW_Editor.Armors", "Armor", new MhwStructData {
                size             = 60,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Set_Group}|{Variant}|{Type}|{Equip_Slot}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Index", 0, typeof(uint), true),
                    new MhwStructData.Entry("Order", 4, typeof(ushort)),
                    new MhwStructData.Entry("Variant", 6, typeof(byte), true, typeof(Variant)),
                    new MhwStructData.Entry("Set (Layered) Id", 7, typeof(ushort), true),
                    new MhwStructData.Entry("Type", 9, typeof(byte), true, typeof(ArmorSetType)),
                    new MhwStructData.Entry("Equip Slot", 10, typeof(byte), true, typeof(ArmorType)),
                    new MhwStructData.Entry("Defense", 11, typeof(ushort)),
                    new MhwStructData.Entry("Model Id 1", 13, typeof(ushort)),
                    new MhwStructData.Entry("Model Id 2", 15, typeof(ushort)),
                    new MhwStructData.Entry("Icon Color", 17, typeof(ushort)),
                    new MhwStructData.Entry("Icon Effect", 19, typeof(byte)),
                    new MhwStructData.Entry("Rarity", 20, typeof(byte)),
                    new MhwStructData.Entry("Cost", 21, typeof(uint)),
                    new MhwStructData.Entry("Fire Res", 25, typeof(sbyte)),
                    new MhwStructData.Entry("Water Res", 26, typeof(sbyte)),
                    new MhwStructData.Entry("Ice Res", 27, typeof(sbyte)),
                    new MhwStructData.Entry("Thunder Res", 28, typeof(sbyte)),
                    new MhwStructData.Entry("Dragon Res", 29, typeof(sbyte)),
                    new MhwStructData.Entry("Slot Count", 30, typeof(byte)),
                    new MhwStructData.Entry("Slot 1 Size", 31, typeof(byte)),
                    new MhwStructData.Entry("Slot 2 Size", 32, typeof(byte)),
                    new MhwStructData.Entry("Slot 3 Size", 33, typeof(byte)),
                    new MhwStructData.Entry("Set Skill 1", 34, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Set Skill 1 Level", 36, typeof(byte)),
                    new MhwStructData.Entry("Hidden Skill", 37, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Hidden Skill Level", 39, typeof(byte)),
                    new MhwStructData.Entry("Skill 1", 40, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 1 Level", 42, typeof(byte)),
                    new MhwStructData.Entry("Skill 2", 43, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 2 Level", 45, typeof(byte)),
                    new MhwStructData.Entry("Skill 3", 46, typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Skill 3 Level", 48, typeof(byte)),
                    new MhwStructData.Entry("Gender", 49, typeof(uint), typeof(Gender)),
                    new MhwStructData.Entry("Set Group", 53, typeof(ushort), true),
                    new MhwStructData.Entry("Is Permanent", 59, typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("GMD Name Index", 55, typeof(ushort), true),
                    new MhwStructData.Entry("GMD Description Index", 57, typeof(ushort), true)
                }
            });
        }
    }
}