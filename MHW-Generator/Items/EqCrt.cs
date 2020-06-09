using System.Collections.Generic;
using MHW_Generator.Models;
using MHW_Template.Armors;
using MHW_Template.Models;
using MHW_Template.Struct_Generation;

namespace MHW_Generator.Items {
    public class EqCrt : SingleStructBase, IMultiStruct {
        public MultiStruct Generate() { // .eq_crt
            var structs = new List<MhwMultiStructData.StructData> {
                CreateSingleStructBase(out var header, out var itemCount),

                new MhwMultiStructData.StructData("Entries", new List<MhwMultiStructData.Entry> {
                    new MhwMultiStructData.Entry("Equipment Category Raw", typeof(byte), true),
                    new MhwMultiStructData.Entry("Equipment Index Raw", typeof(ushort), true),
                    new MhwMultiStructData.Entry("Needed Item Id to Unlock", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Monster Unlock", typeof(int), dataSourceType: DataSourceType.MonstersNeg),
                    new MhwMultiStructData.Entry("Story Unlock", typeof(uint)),
                    new MhwMultiStructData.Entry("Unknown (uint32)", typeof(uint)),
                    new MhwMultiStructData.Entry("Item Rank", typeof(uint), enumReturn: typeof(CharmRankType)),
                    new MhwMultiStructData.Entry("Mat 1 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 1 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 2 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 2 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 3 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 3 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Mat 4 Id", typeof(ushort), dataSourceType: DataSourceType.Items),
                    new MhwMultiStructData.Entry("Mat 4 Count", typeof(byte)),
                    new MhwMultiStructData.Entry("Unknown (uint8) 1", typeof(byte)),
                    new MhwMultiStructData.Entry("Unknown (uint8) 2", typeof(byte)),
                    new MhwMultiStructData.Entry("Unknown (uint8) 3", typeof(byte)),
                    new MhwMultiStructData.Entry("Unknown (uint8) 4", typeof(byte))
                }, _010Link: new MhwMultiStructData.ArrayLink(header, itemCount), uniqueIdFormula: "{Equipment_Category_Raw}|{Equipment_Index_Raw}")
            };

            return new MultiStruct("MHW_Editor.Items", "EqCrt", new MhwMultiStructData(structs, "eq_crt"));
        }
    }
}