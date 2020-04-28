using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;

namespace MHW_Generator.Weapons {
    public class GunnerReload : ISingleStruct {
        public SingleStruct Generate() { // .gun_rd
            return new SingleStruct("MHW_Editor.Weapons", "GunnerReload", new MhwStructData {
                size             = 5,
                offsetInitial    = 10,
                entryCountOffset = 6,
                uniqueIdFormula  = "{Id}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("No Mods", 0, typeof(byte), dataSourceType: DataSourceType.GunnerReload),
                    new MhwStructData.Entry("Mod 1", 1, typeof(byte), dataSourceType: DataSourceType.GunnerReload),
                    new MhwStructData.Entry("Mod 2", 2, typeof(byte), dataSourceType: DataSourceType.GunnerReload),
                    new MhwStructData.Entry("Mod 3", 3, typeof(byte), dataSourceType: DataSourceType.GunnerReload),
                    new MhwStructData.Entry("Mod 4", 4, typeof(byte), dataSourceType: DataSourceType.GunnerReload)
                }
            });
        }
    }
}