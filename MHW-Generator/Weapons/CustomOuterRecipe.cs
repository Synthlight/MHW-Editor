using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class CustomOuterRecipe : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .cus_otr
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Unk1", typeof(byte)),
                    new MhwMultiStructData.Entry("Needed Item Id to Unlock", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Unk3", typeof(int)),
                    new MhwMultiStructData.Entry("Unk4", typeof(int)),
                    new MhwMultiStructData.Entry("Cost", typeof(uint)),
                    new MhwMultiStructData.Entry("Mat 1 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 1 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 2 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 2 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 3 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 3 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 4 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 4 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk5", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk6", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk7", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk8", typeof(byte))
                }, canAddRows: true, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount))
            };

            return new MultiStruct("Weapons", "CustomOuterRecipe", new MhwMultiStructData(structs, "cus_otr", EncryptionKeys.FILE_EXT_KEY_LOOKUP[".cus_otr"]));
        }
    }
}