using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;
using MHW_Template.Weapons;

namespace MHW_Generator.Weapons {
    public class CustomPartsR : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .cus_par
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Weapon Type", typeof(byte), true, typeof(WeaponType)),
                    new MhwMultiStructData.Entry("Id", typeof(uint), true, overrideSortIndex: true),
                    new MhwMultiStructData.Entry("Needed Item Id to Unlock", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk 1", typeof(int)),
                    new MhwMultiStructData.Entry("Unk 2", typeof(int)),
                    new MhwMultiStructData.Entry("Mat 1 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 1 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 2 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 2 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 3 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 3 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 4 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 4 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 3", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 8", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 9", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 10", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 11", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 12", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 13", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 14", typeof(ushort))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id}|{Weapon_Type}")
            };

            return new MultiStruct("Weapons", "CustomPartsR", new MhwMultiStructData(structs, "cus_par", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_par"]));
        }
    }
}