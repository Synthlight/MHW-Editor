using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class AwakenedLimitBreak : ISingleStruct {
        public SingleStruct Generate() { // .em104lb
            return new SingleStruct("MHW_Editor.Weapons", "AwakenedLimitBreak", new MhwStructData {
                size = 49,
                offsetInitial = 10,
                entryCountOffset = 6,
                uniqueIdFormula = "{Index}",
                autoOffset = true,
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Skill Id", typeof(ushort), dataSourceType: DataSourceType.Skills),
                    new MhwStructData.Entry("Group Id", typeof(uint)),
                    new MhwStructData.Entry("Rarity", typeof(uint)),
                    new MhwStructData.Entry("Unk", typeof(uint)),
                    new MhwStructData.Entry("Has Upgrade", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Previous Upgrade Id When Max Lvl", typeof(ushort)),
                    new MhwStructData.Entry("Next Upgrade Id", typeof(ushort)),
                    new MhwStructData.Entry("Can Stack", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk8", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Lvl 1 Id", typeof(ushort)),
                    new MhwStructData.Entry("Lvl 2 Id", typeof(ushort)),
                    new MhwStructData.Entry("Lvl 3 Id", typeof(ushort)),
                    new MhwStructData.Entry("Lvl 4 Id", typeof(ushort)),
                    new MhwStructData.Entry("Lvl 5 Id", typeof(ushort)),
                    new MhwStructData.Entry("Works on Great Sword", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Sword & Shield", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Dual Blades", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Long Sword", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Hammer", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Hunting Horn", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Lance", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Gunlance", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Switch Axe", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Charge Blade", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Insect Glaive", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on Bow", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on HBG", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Works on LBG", typeof(byte), typeof(bool)),
                    new MhwStructData.Entry("Unk28", typeof(byte))
                }
            });
        }
    }
}