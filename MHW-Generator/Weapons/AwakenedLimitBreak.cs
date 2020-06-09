using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class AwakenedLimitBreak : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .em104lb
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Skill Id", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwMultiStructData.Entry("Group Id", typeof(uint)),
                    new MhwMultiStructData.Entry("Rarity", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk", typeof(uint)),
                    new MhwMultiStructData.Entry("Has Upgrade", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Previous Upgrade Id When Max Lvl", typeof(ushort)),
                    new MhwMultiStructData.Entry("Next Upgrade Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Can Stack", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk8", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Lvl 1 Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Lvl 2 Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Lvl 3 Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Lvl 4 Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Lvl 5 Id", typeof(ushort)),
                    new MhwMultiStructData.Entry("Works on Great Sword", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Sword & Shield", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Dual Blades", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Long Sword", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Hammer", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Hunting Horn", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Lance", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Gunlance", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Switch Axe", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Charge Blade", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Insect Glaive", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on Bow", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on HBG", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Works on LBG", typeof(byte), enumReturn: typeof(bool)),
                    new MhwMultiStructData.Entry("Unk 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("MHW_Editor.Weapons", "AwakenedLimitBreak", new MhwMultiStructData(structs, "em104lb"));
        }
    }
}