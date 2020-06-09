using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Weapons {
    public class NewLimitBreakR : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .new_lbr
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Id 1", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Id 2", typeof(ushort), true),
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
                    new MhwMultiStructData.Entry("Unk 3", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 4", typeof(uint)),
                    new MhwMultiStructData.Entry("Unk 5", typeof(ushort)),
                    new MhwMultiStructData.Entry("Unk 6", typeof(byte)),
                    new MhwMultiStructData.Entry("Unk 7", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Id_1}|{Id_2}")
            };

            return new MultiStruct("MHW_Editor.Weapons", "NewLimitBreakR", new MhwMultiStructData(structs, "new_lbr"));
        }
    }
}