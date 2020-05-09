using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Struct_Generation.Single;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class CustomPartsR : ISingleStruct {
        public SingleStruct Generate() { // .cus_par
            return new SingleStruct("MHW_Editor.Weapons", "CustomPartsR", new MhwStructData {
                size             = 51,
                offsetInitial    = 10,
                entryCountOffset = 6,
                encryptionKey    = EncryptionKeys.CUS_PAR_KEY,
                uniqueIdFormula  = "{Id}|{Weapon_Type}",
                entries = new List<MhwStructData.Entry> {
                    new MhwStructData.Entry("Id", 1, typeof(uint), true),
                    new MhwStructData.Entry("Weapon Type", 0, typeof(byte), true, typeof(WeaponType)),
                    new MhwStructData.Entry("Needed Item Id to Unlock", 5, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Unk2", 7, typeof(int)),
                    new MhwStructData.Entry("Mat 1 Id", 15, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 1 Count", 17, typeof(byte)),
                    new MhwStructData.Entry("Mat 2 Id", 18, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 2 Count", 20, typeof(byte)),
                    new MhwStructData.Entry("Mat 3 Id", 21, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 3 Count", 23, typeof(byte)),
                    new MhwStructData.Entry("Mat 4 Id", 24, typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwStructData.Entry("Mat 4 Count", 26, typeof(byte)),
                    new MhwStructData.Entry("Unk3", 27, typeof(ushort)),
                    new MhwStructData.Entry("Unk4", 29, typeof(ushort)),
                    new MhwStructData.Entry("Unk5", 31, typeof(ushort)),
                    new MhwStructData.Entry("Unk6", 33, typeof(ushort)),
                    new MhwStructData.Entry("Unk7", 50, typeof(byte))
                }
            });
        }
    }
}